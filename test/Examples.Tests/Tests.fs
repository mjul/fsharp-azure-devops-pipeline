module Examples.Tests

open System
open Xunit
open FsCheck.Xunit

open Examples


[<Fact>]
let ``FlakyCalculator can add two plus two`` () =
    let actual = Examples.FlakyCalculator.add 2 2
    Assert.Equal(4, actual)


[<Theory>]
[<InlineData(1,2,3)>]
[<InlineData(2,3,5)>]
[<InlineData(-1,1,0)>]
let ``FlakyCalculator can add two integers`` a b expected =
    let actual = Examples.FlakyCalculator.add a b
    Assert.Equal(expected, actual)


// Note: this finds the bug in FlakyCalculator:
    
[<Property>]
let ``FlakyCalculator add is commutative`` a b =
    let sum_ab= Examples.FlakyCalculator.add a b
    let sum_ba= Examples.FlakyCalculator.add b a
    Assert.Equal(sum_ab, sum_ba)
