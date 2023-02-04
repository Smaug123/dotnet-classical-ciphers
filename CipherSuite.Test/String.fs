namespace CipherSuite.Test

[<RequireQualifiedAccess>]
module String =

    let stripNonAlpha (s : string) =
        s.ToCharArray ()
        |> Array.choose (fun c ->
            let c = System.Char.ToUpper c
            let shifted = int c - 65
            if shifted >= 0 && shifted < 26 then Some c else None
        )
        |> System.String
