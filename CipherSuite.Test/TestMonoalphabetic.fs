namespace CipherSuite.Test

open CipherSuite
open NUnit.Framework
open FsUnitTyped

[<TestFixture>]
module TestMonoalphabetic =

    [<Test>]
    let ``Challenge 1A`` () =
        let rand = System.Random 10

        let key, _plain, _fitness =
            Monoalphabetic.crack rand 20000 (String.stripNonAlpha Examples.challenge1A)

        key |> shouldEqual [| yield! [| 19..25 |] ; yield! [| 0..18 |] |]
