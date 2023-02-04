namespace CipherSuite

#if DEBUG
#else
#nowarn "9"
#endif

open System.Text

[<RequireQualifiedAccess>]
module Affine =

    let private hcf (i : int) (j : int) =
        let rec go (bigger : int) (smaller : int) =
            if smaller = 0 then
                bigger
            else
                go smaller (bigger % smaller)

        if i < 0 || j < 0 then
            failwithf "HCF only implemented for positive numbers, got %i %i" i j

        go (max i j) (min i j)

    /// multiplier must be coprime to 26.
    let encrypt (multiplier : int) (add : int) (s : string) : string =
        if hcf multiplier 26 <> 1 then
            failwithf "multiplier must be coprime to 26, got %i" multiplier

        let sb = StringBuilder ()

        for c in s do
            if 'A' <= c && c <= 'Z' then
                sb.Append (((int c - int 'A') * multiplier + add) % 26 + int 'A' |> char)
            elif 'a' <= c && c <= 'z' then
                sb.Append (((int c - int 'a') * multiplier + add) % 26 + int 'a' |> char)
            else
                sb.Append c
            |> ignore

        sb.ToString ()

    /// Returns the inverse of the correct key, because I'm lazy.
    let crack (s : string) =
#if DEBUG
        let fitness = Fitness.fromEmbedded ()
#else
        let arr = Fitness.allocate ()
        use ptr = fixed arr
        let fitness = Fitness.fromEmbedded ptr
#endif
        seq {
            for mul in 1..2..25 do
                if mul <> 13 then
                    for add in 0..25 do
                        let encrypt = encrypt mul add s
                        yield (mul, add), encrypt, Fitness.get encrypt fitness
        }
        |> Seq.maxBy (fun (_, _, fitness) -> fitness)
