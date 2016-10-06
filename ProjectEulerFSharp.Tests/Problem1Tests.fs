namespace ProjectEuler

module Problem1Tests =  
    open Xunit

    [<Fact>]
    let ``sum of multiples below 10 is 23`` () =
        let actual = Problem1.SumOfMultiplesOfThreeAndFiveBelow 10
        Assert.Equal(23, actual)
        ()

    [<Fact>]
    let ``sum of multiples below 11 is 33`` () =
        let actual = Problem1.SumOfMultiplesOfThreeAndFiveBelow 11
        Assert.Equal(33, actual)
        ()

    [<Fact>]
    let ``sum of multiples below 13 is 45`` () =
        let actual = Problem1.SumOfMultiplesOfThreeAndFiveBelow 13
        Assert.Equal(45, actual)
        ()

    [<Fact>]
    let ``sum of multiples below 16 is 60`` () =
        let actual = Problem1.SumOfMultiplesOfThreeAndFiveBelow 16
        Assert.Equal(60, actual)
        ()

    [<Fact>]
    let ``sum of multiples below 100 is 233168`` () =
        let actual = Problem1.SumOfMultiplesOfThreeAndFiveBelow 1000
        Assert.Equal(233168, actual)
        ()