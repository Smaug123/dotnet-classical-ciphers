namespace CipherSuite.Test

open NUnit.Framework
open CipherSuite
open FsUnitTyped

[<TestFixture>]
module TestAffine =

    [<Test>]
    let ``Examples, Challenge 1`` () =
        let key, plain, fitness = Affine.crack Examples.challenge1A

        plain.StartsWith "I WAS HOPING I WOULD FIND YOU HERE" |> shouldEqual true

        // Note: this is the inverse of the correct key
        key |> shouldEqual (1, 19)

        let key, plain, fitness = Affine.crack Examples.challenge1B

        plain.StartsWith "DEAR MS FRANK," |> shouldEqual true

        key |> shouldEqual (1, 7)

    [<Test>]
    let ``Examples, Challenge 2`` () =
        let key, plain, fitness = Affine.crack Examples.challenge2A

        plain.StartsWith "I MANAGED TO TRACE JADE/JODIE TO A SUITE" |> shouldEqual true

        // Note: this is the inverse of the correct key
        key |> shouldEqual (21, 6)

        let key, plain, fitness = Affine.crack Examples.challenge2B

        plain.StartsWith "DEAR MS FRANK," |> shouldEqual true

        key |> shouldEqual (3, 11)

    [<Test>]
    let ``Examples, Challenge 3`` () =
        let key, plain, fitness = Affine.crack Examples.challenge3A

        plain.StartsWith "JODIE ISMAK INGTH ISVER YEASY FORME HERRE CENTC"
        |> shouldEqual true

        // Note: this is the inverse of the correct key
        key |> shouldEqual (1, 18)
