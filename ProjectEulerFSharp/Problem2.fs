namespace ProjectEuler

module Problem2 =
    let rec FibonacciNumber i = 
        if i > 2 then FibonacciNumber (i - 1) + FibonacciNumber (i - 2) else i 

    let FibonacciSequence length =
        Seq.init length (fun i -> i + 1 |> FibonacciNumber)

    let FibonacciNumbersLessThanOrEqualTo maxValue =
        1
        |> Seq.unfold(fun x -> if ((FibonacciNumber x)<=maxValue) then Some(FibonacciNumber x,x+1) else None)

    let IsEven i =
        i % 2 = 0

    let EvenFibonacciNumbersLessThanOrEqualTo maxValue =
        FibonacciNumbersLessThanOrEqualTo maxValue |> Seq.filter IsEven

    let SumOfEvenFibonacciNumbersLessThanOrEqualTo maxValue =
        EvenFibonacciNumbersLessThanOrEqualTo maxValue |> Seq.sum