open System
let rec ReadList n =
    List.init(n) (fun index->Convert.ToInt32(Console.ReadLine()))

let rec WriteList list=
    List.iter(fun x->printfn "%O" x) list

let Result_List list a b = List.fold (fun s x -> if  (x= List.min list && x>a && x<b) then s+1 else s) 0 list 

let result list a b= List.fold (fun s x -> if (x=List.min list && x>a && x<b) then s+1 else s) 0 list

[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите интервал: ")
    Console.WriteLine("a: ")
    let a = Convert.ToInt32(Console.ReadLine())
    Console.WriteLine("b: ")
    let b = Convert.ToInt32(Console.ReadLine())
    Console.WriteLine("Введите список: ")
    let n = Convert.ToInt32(Console.ReadLine())
    let list= ReadList 5
    Console.WriteLine("Результат")
    Console.WriteLine(Result_List list a b )
    Console.WriteLine(result list 1 3)
    0