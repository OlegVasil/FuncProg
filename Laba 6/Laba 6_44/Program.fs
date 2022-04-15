open System 

let rec ReadList n = 
    if n=0 then []
    else 
    let Head = Convert.ToDouble(Console.ReadLine()) 
    let Tail = ReadList (n-1)
    Head::Tail
    
let Check (list: float list) = 
    let rec check list h2 =
       match list with 
       | h::t ->
            if ((h%1.0=0.0 && h2%1.0=0.0) || (h%1.0<>0.0 && h2%1.0<>0.0)) then false 
                else check t h
       | []->true 
    check list.Tail list.Head

[<EntryPoint>]

let main argv = 
    Console.WriteLine("Введите массив: ")
    let n = Convert.ToInt32(Console.ReadLine())
    let list = ReadList n 
    Console.WriteLine(Check list)
    0
