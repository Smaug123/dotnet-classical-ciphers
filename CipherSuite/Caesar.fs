namespace CipherSuite

#if DEBUG
#else
#nowarn "9"
#endif

[<RequireQualifiedAccess>]
module Caesar =

    let shift (s : string) (i : int) : string =
        Array.init
            s.Length
            (fun index ->
                let c = s.[index]

                if 'A' <= c && c <= 'Z' then
                    char ((int c - int 'A' + i) % 26 + int 'A')
                elif 'a' <= c && c <= 'z' then
                    char ((int c - int 'a' + i) % 26 + int 'a')
                else
                    c
            )
        |> System.String

    let crack (s : string) =
#if DEBUG
        let fitness = Fitness.fromEmbedded ()
#else
        let arr = Fitness.allocate ()
        use ptr = fixed arr
        let fitness = Fitness.fromEmbedded ptr
#endif

        seq { 0..25 }
        |> Seq.map (fun i -> 25 - i, shift s i)
        |> Seq.map (fun (shift, text) -> (shift, text, Fitness.get text fitness))
        |> Seq.maxBy (fun (_, _, fitness) -> fitness)
