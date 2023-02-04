namespace CipherSuite

#if DEBUG
#else
#nowarn "9"
#endif

[<RequireQualifiedAccess>]
module Monoalphabetic =

    /// The hill climber is allowed to accept a worse solution sometimes
    /// (in the name of escaping local optima). This is a table of probabilities
    /// for how much worse the solution is allowed to be; for example, there is a
    /// 5 in 20 chance that we don't accept any worse solution, and a 2 in 20 chance
    /// we accept a solution that is 8-or-more worse.
    /// I have completely lost the source of these numbers, and it appears that
    /// by sheer coincidence the scale I chose for the built-in fitness function
    /// happens to be very compatible with these perturbations.
    let private perturbations =
        [|
            0
            0
            0
            0
            0
            1
            1
            1
            1
            1
            2
            2
            2
            3
            4
            4
            5
            6
            8
            15
        |]
        |> Array.map float

    let private decrypt (key : int[]) (ciphertext : int[]) (output : int[]) : unit =
        for i = 0 to ciphertext.Length - 1 do
            output.[i] <- key.[ciphertext.[i]]

    let inline private swap (arr : int[]) (p1 : int) (p2 : int) : unit =
        let temp = arr.[p1]
        arr.[p1] <- arr.[p2]
        arr.[p2] <- temp

    let rec private backToString (text : int[]) : string =
        text |> Array.map ((+) (int 'a') >> char) |> System.String

    // I *think* this may originally be an algorithm described in
    // http://web.archive.org/web/20110210123730/http://web.mac.com/mikejcowan/Ciphers/Churn_Algorithm.html
    // But it was over a decade ago and I've simply forgotten the source.
    let crack (rand : System.Random) (keysLimit : int) (ciphertext : string) : int[] * string * float =
        let ciphertext = ciphertext.ToUpperInvariant ()
#if DEBUG
        let fitness = Fitness.fromEmbedded ()
#else
        let arr = Fitness.allocate ()
        use ptr = fixed arr
        let fitness = Fitness.fromEmbedded ptr
#endif
        let plaintext =
            Array.init
                ciphertext.Length
                (fun i ->
                    let output = int ciphertext.[i] - int 'A'

                    if output < 0 || output > 25 then
                        failwith "non-alphabetic character"

                    output
                )

        let ciphertext = Array.copy plaintext
        let currentKey = [| 0..25 |]
        let bestKey = Array.copy currentKey
        decrypt currentKey ciphertext plaintext
        let mutable currentFitness = Fitness.get' plaintext fitness
        let mutable bestFitness = currentFitness
        let mutable keyCount = 0

        while keyCount < keysLimit do
            let swap1 = rand.Next (0, 26)
            let swap2 = rand.Next (0, 25)
            let swap2 = if swap2 < swap1 then swap2 else swap2 + 1

            swap currentKey swap1 swap2

            // We could do better here, because the plaintext changes
            // only in well-defined ways from loop to loop.
            // I'm lazy.
            decrypt currentKey ciphertext plaintext

            let newFitness = Fitness.get' plaintext fitness

            if newFitness > bestFitness then
                bestFitness <- newFitness
                currentFitness <- newFitness
                Array.blit currentKey 0 bestKey 0 currentKey.Length
            elif newFitness > currentFitness - perturbations.[rand.Next (0, perturbations.Length)] then
                // This guess wasn't the best we've had, but it's good enough when we
                // add in a bit of jitter to get us out of local optima.
                currentFitness <- newFitness
            else
                // Revert this guess, it wasn't sufficiently high fitness
                swap currentKey swap1 swap2

            keyCount <- keyCount + 1

        decrypt bestKey ciphertext plaintext
        let plaintext = backToString plaintext
        bestKey, plaintext, bestFitness
