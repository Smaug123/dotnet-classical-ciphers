{
  description = "Transcription of some classical cipher solvers from Pascal";

  inputs = {
    flake-utils.url = "github:numtide/flake-utils";
    nixpkgs.url = "nixpkgs/nixpkgs-unstable";
  };

  outputs = {
    self,
    nixpkgs,
    flake-utils,
    ...
  }:
    flake-utils.lib.eachDefaultSystem (system: let
      pkgs = nixpkgs.legacyPackages.${system};
      projectFile = "./CipherSuite/CipherSuite.fsproj";
      testProjectFile = "./CipherSuite.Test/CipherSuite.Test.fsproj";
      pname = "dotnet-cipher-suite";
      dotnet-sdk = pkgs.dotnet-sdk_7;
      dotnet-runtime = pkgs.dotnetCorePackages.runtime_7_0;
      version = "0.1";
      dotnetTool = toolName: toolVersion: sha256:
        pkgs.stdenvNoCC.mkDerivation rec {
          name = toolName;
          version = toolVersion;
          nativeBuildInputs = [pkgs.makeWrapper];
          src = pkgs.fetchNuGet {
            pname = name;
            version = version;
            sha256 = sha256;
            installPhase = ''mkdir -p $out/bin && cp -r tools/net6.0/any/* $out/bin'';
          };
          installPhase = ''
            runHook preInstall
            mkdir -p "$out/lib"
            cp -r ./bin/* "$out/lib"
            makeWrapper "${dotnet-runtime}/bin/dotnet" "$out/bin/${name}" --add-flags "$out/lib/${name}.dll"
            runHook postInstall
          '';
        };
    in {
      packages = {
        fantomas = dotnetTool "fantomas" (builtins.fromJSON (builtins.readFile ./.config/dotnet-tools.json)).tools.fantomas.version "sha256-zYSF53RPbGEQt1ZBcHVYqEPHrFlmI1Ty3GQPW1uxPWw=";
        fetchDeps = let
          flags = [];
          runtimeIds = ["win-x64"] ++ map (system: pkgs.dotnetCorePackages.systemToDotnetRid system) dotnet-sdk.meta.platforms;
        in
          pkgs.writeShellScriptBin "fetch-${pname}-deps" (builtins.readFile (pkgs.substituteAll {
            src = ./nix/fetchDeps.sh;
            pname = pname;
            binPath = pkgs.lib.makeBinPath [pkgs.coreutils dotnet-sdk (pkgs.nuget-to-nix.override {inherit dotnet-sdk;})];
            projectFiles = toString (pkgs.lib.toList projectFile);
            testProjectFiles = toString (pkgs.lib.toList testProjectFile);
            rids = pkgs.lib.concatStringsSep "\" \"" runtimeIds;
            packages = dotnet-sdk.packages;
            storeSrc = pkgs.srcOnly {
              src = ./.;
              pname = pname;
              version = version;
            };
          }));
        default = pkgs.buildDotnetModule {
          pname = pname;
          name = "cipher-suite";
          version = version;
          src = ./.;
          projectFile = projectFile;
          nugetDeps = ./nix/deps.nix;
          doCheck = true;
          dotnet-sdk = dotnet-sdk;
          dotnet-runtime = dotnet-runtime;
        };
      };
      devShell = pkgs.mkShell {
        buildInputs = with pkgs; [
          (with dotnetCorePackages;
            combinePackages [
              dotnet-sdk_7
              dotnetPackages.Nuget
            ])
        ];
        packages = [
          pkgs.alejandra
          pkgs.nodePackages.markdown-link-check
          pkgs.shellcheck
        ];
      };
    });
}
