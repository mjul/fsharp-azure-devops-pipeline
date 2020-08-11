module Examples.Tests

open System
open Xunit

open Examples


[<Fact>]
let ``FlakyCalculator can add two plus two`` () =
    let actual = Examples.FlakyCalculator.add 2 2
    Assert.Equal(4, actual)


[<Theory>]
[<InlineData(1,2,3)>]
let ``FlakyCalculator can add two integers`` a b expected =
    let actual = Examples.FlakyCalculator.add a b
    Assert.Equal(expected, actual)
