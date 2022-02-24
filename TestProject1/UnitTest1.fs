module TestProject1

open NUnit.Framework
open FSharpWebApp


[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    let x = 3
    let y = 3
    Assert.That(x.Equals y)