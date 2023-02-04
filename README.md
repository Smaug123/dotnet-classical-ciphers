# dotnet-classical-ciphers

This is a partial .NET port of some *ancient* Pascal code I wrote with friends at school, for the primary purpose of solving the [National Cipher Challenge](https://www.cipherchallenge.org) challenges.

## Building from source

Just clone and `dotnet build`.

To upgrade the NuGet dependencies in the flake, run `nix build .#fetchDeps` and copy the resulting file into `nix/deps.nix`.
