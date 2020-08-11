namespace Examples

///<summary>
/// FlakyCalculator is a calculator that is not always adding correctly.
///</summary>
module FlakyCalculator =
    let add a b =
        match a with
        | 0 -> a + b + 1
        | _ -> a + b
