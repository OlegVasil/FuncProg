open System

let rec ReadList n =
    List.init(n) (fun index->Convert.ToInt32(Console.ReadLine()))

let rec WriteList list=
    List.iter(fun x->printfn "%O" x) list

let Counta str =
    let new_str=String.filter(fun ch->ch='A') str
    Console.WriteLine(new_str.Length)

[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите строку")
    let str = Console.ReadLine()
    Counta str
    0 