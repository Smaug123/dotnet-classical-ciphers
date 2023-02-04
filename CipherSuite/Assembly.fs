namespace CipherSuite

open System.IO

[<RequireQualifiedAccess>]
module internal Assembly =
    let loadResource (name : string) =
        let assembly = System.Reflection.Assembly.GetExecutingAssembly ()

        if not (assembly.GetManifestResourceNames () |> Array.contains name) then
            assembly.GetManifestResourceNames ()
            |> String.concat ", "
            |> failwithf "bad name %s, had: %s" name

        seq {
            use sr = new StreamReader (assembly.GetManifestResourceStream name)
            let mutable line = sr.ReadLine ()

            while not (obj.ReferenceEquals (null, line)) do
                yield line
                line <- sr.ReadLine ()
        }
