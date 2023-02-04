namespace CipherSuite.Test

open NUnit.Framework
open CipherSuite
open FsUnitTyped

[<TestFixture>]
module TestCaesar =

    [<Test>]
    let ``Examples, Challenge 1`` () =
        let key, plain, fitness = Caesar.crack Examples.challenge1A

        plain.StartsWith "I WAS HOPING I WOULD FIND YOU HERE" |> shouldEqual true

        printfn "%f" fitness
        key |> shouldEqual 6

        let key, plain, fitness = Caesar.crack Examples.challenge1B

        plain.StartsWith "DEAR MS FRANK," |> shouldEqual true

        key |> shouldEqual 18
