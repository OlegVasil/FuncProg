open System

let rec ReadList n = 
    if n=0 then []
    else 
    let Head = Convert.ToInt32(Console.ReadLine()) 
    let Tail = ReadList (n-1)
    Head::Tail

let ChisCount list a b=
    let rec count1 list a b acc=
        match list with
        | h::t-> 
            if (h>a && h<b) then count1 t a b acc+1
            else count1 t a b acc
        |[]->acc
    count1 list a b 0

[<EntryPoint>]

let main argv =
    Console.WriteLine("Введите интервал: ")
    Console.Write("a: ")
    let a = Convert.ToInt32(Console.ReadLine())
    Console.Write("b: ")
    let b = Convert.ToInt32(Console.ReadLine())
    Console.WriteLine("Введите список: ")
    let n = Convert.ToInt32(Console.ReadLine())
    let list = ReadList n
    Console.WriteLine(ChisCount list a b)
    0