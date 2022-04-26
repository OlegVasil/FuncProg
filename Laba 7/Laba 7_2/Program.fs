open System
let rec ReadList n =
    List.init(n) (fun index->Convert.ToInt32(Console.ReadLine()))
let rec WriteList list=
    List.iter(fun x->printfn "%O" x) list
let Min_id list=List.findIndex(fun x->x=List.min list) list

[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите список: ")
    let n = Convert.ToInt32(Console.ReadLine())
    let list= ReadList n
    Console.WriteLine(Min_id list+1)
    0