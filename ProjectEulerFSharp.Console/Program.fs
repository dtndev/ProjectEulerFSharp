// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System
open ProjectEuler

[<EntryPoint>]
let main argv = 
    printfn "Enter problem number"
    let problemNumber = Int32.Parse(Console.ReadLine())

    match problemNumber with
        | 1 -> 
            printfn "Calculate sum of multiples of 3 and 5 less than..."
            let number =  Int32.Parse(Console.ReadLine())
            let sum = Problem1.SumOfMultiplesOfThreeAndFiveBelow number
            "Sum is " + sum.ToString() |> Console.WriteLine 
        | 2 -> 
            printfn "Calculate sum of even fibonacci numbers not exceeding..."
            let number =  Int32.Parse(Console.ReadLine())
            let sum = Problem2.SumOfEvenFibonacciNumbersLessThanOrEqualTo number
            "Sum is " + sum.ToString() |> Console.WriteLine 
        | _ -> 
            printfn "Problem number %i not supported" problemNumber 
       
    printfn "Press any key to exit" 
    Console.ReadLine() |> ignore
    0 // return an integer exit code

    

    
