namespace ProjectEuler

module Problem2Tests =  
    open Xunit

    [<Fact>]
    let ``fibonacci 1`` () =
        let actual = Problem2.FibonacciNumber 1
        Assert.Equal(1, actual)
        ()

    [<Fact>]
    let ``fibonacci 2`` () =
        let actual = Problem2.FibonacciNumber 2
        Assert.Equal(2, actual)
        ()

    [<Fact>]
    let ``fibonacci 4`` () =
        let actual = Problem2.FibonacciNumber 4
        Assert.Equal(5, actual)
        ()

    [<Fact>]
    let ``first 2 fibonacci`` () =
        let actual = Problem2.FibonacciSequence 2
        let expected = [1; 2]
        let equal = expected = Seq.toList actual
        Assert.True(equal)
        ()

    [<Fact>]
    let ``first 4 fibonacci`` () =
        let actual = Problem2.FibonacciSequence 4
        let expected = [1; 2; 3; 5]
        let equal = expected = Seq.toList actual
        Assert.True(equal)
        ()

    [<Fact>]
    let ``fibonacci less than 3`` () =
        let actual = Problem2.FibonacciNumbersLessThanOrEqualTo 2
        let expected = [1; 2]
        let equal = expected = Seq.toList actual
        Assert.True(equal)
        ()

    [<Fact>]
    let ``fibonacci less than 6`` () =
        let actual = Problem2.FibonacciNumbersLessThanOrEqualTo 5 |> Seq.toList 
        let expected = [1; 2; 3; 5]
        let equal = expected = actual
        Assert.True(equal)
        ()

    [<Fact>]
    let ``fibonacci less than 90`` () =
        let actual = Problem2.FibonacciNumbersLessThanOrEqualTo 89 |> Seq.toList 
        let expected = [1; 2; 3; 5; 8; 13; 21; 34; 55; 89]
        let equal = expected = actual
        Assert.True(equal)
        ()

    [<Fact>]
    let ``even fibonacci less than 90`` () =
        let actual = Problem2.EvenFibonacciNumbersLessThanOrEqualTo 89 |> Seq.toList 
        let expected = [2; 8; 34;]
        let equal = expected = actual
        Assert.True(equal)
        ()

    [<Fact>]
    let ``sum of even fibonacci less than 90`` () =
        let actual = Problem2.SumOfEvenFibonacciNumbersLessThanOrEqualTo 89 
        Assert.Equal(44, actual)
        ()
