namespace ProjectEuler

module Problem1 =
    let IsMultipleOf divisor number  = 
        number % divisor = 0

    let IsMultipleOfThreeOrFive n =
        n |> IsMultipleOf 3 || n |> IsMultipleOf 5

    let SumOfMultiplesOfThreeAndFiveBelow n =
        {1..n-1}
        |> Seq.filter IsMultipleOfThreeOrFive  
        |> Seq.sum