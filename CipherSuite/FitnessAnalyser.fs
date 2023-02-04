namespace CipherSuite

open System

type Fitness =
    private
        {
            Quadruplets : Arr4D<int>
            Total : int
        }

[<RequireQualifiedAccess>]
module Fitness =

    let inline private toIndex (c : char) : int = int (System.Char.ToUpper c) - 65

#if DEBUG
    let fromEmbedded () : Fitness =
        let frequencies = Arr4D.zeroCreate<_> 26 26 26 26
#else

    let allocate () =
        Array.zeroCreate<int> (26 * 26 * 26 * 26)

    /// Pass in a pointer to an array of length 26*26*26*26, e.g. a pointer to
    /// the output of `allocate`.
    let fromEmbedded (arr : nativeptr<int>) : Fitness =
        let frequencies = Arr4D.zeroCreate<_> arr 26 26 26 26
#endif
        let tetragraphs = Assembly.loadResource "CipherSuite.tetragraphs.txt"

        let mutable total = 0

        for line in tetragraphs do
            if line.[0] <> '#' then
                let line = line.AsSpan ()
                let i = Int32.Parse (line.Slice (line.IndexOf (' ') + 1))
                total <- total + i
                let w = toIndex line.[0]
                let x = toIndex line.[1]
                let y = toIndex line.[2]
                let z = toIndex line.[3]

                if w < 0 || x < 0 || y < 0 || z < 0 then
                    failwith "negative"

                if w > 25 || x > 25 || y > 25 || z > 25 then
                    failwith "too big"

                Arr4D.set frequencies w x y z i

        {
            Quadruplets = frequencies
            Total = total
        }

    /// Assumes the input is characters 0..25, where "a" is 0.
    /// This fitness can meaningfully be compared across strings
    /// with different lengths.
    let get' (s : int[]) (f : Fitness) : float =
        let mutable score = 0

        for j = 0 to s.Length - 4 do
            let first = s.[j]
            let second = s.[j + 1]
            let third = s.[j + 2]
            let fourth = s.[j + 3]

            score <- score + Arr4D.get f.Quadruplets first second third fourth

        float score / float s.Length

    let get (s : string) (f : Fitness) : float =
        let s =
            s.ToUpper().ToCharArray ()
            |> Array.choose (fun c ->
                if 'A' <= c && c <= 'Z' then
                    Some (int c - int 'A')
                else
                    None
            )

        get' s f
