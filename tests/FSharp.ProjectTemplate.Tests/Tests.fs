module FSharp.ProjectScaffold.Tests

open NUnit.Framework

[<Test>]
let ``dummy test`` () =
  let result = 42
  printfn "%i" result
  Assert.AreEqual(42,result)
