open System 

let rec ReadList n = 
    if n=0 then []
    else 
    let Head = Convert.ToInt32(Console.ReadLine()) 
    let Tail = ReadList (n-1)
    Head::Tail

let Amount list a b = 
    let rec amount list a b count =
        match list with 
        | h::t->
            if (h>=a && h<=b) then amount t a b (count+1)
            else amount t a b count 
        | []->count 
    amount list a b 0

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
    Console.WriteLine(Amount list a b )
    0