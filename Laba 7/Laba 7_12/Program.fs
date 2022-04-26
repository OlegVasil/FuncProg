open System
let rec ReadList n =
    List.init(n) (fun index->Convert.ToInt32(Console.ReadLine()))

let rec WriteList list=
    List.iter(fun x->printfn "%O" x) list

let Find_Min list=List.findIndex(fun x->x=List.min list) list
let Find_Max list=List.findIndex(fun x->x=List.max list) list

let Result_List list= 
    let start=Math.Min(Find_Max list,Find_Min list)
    let endpoint=Math.Max(Find_Min list,Find_Max list)
    let piece=list.[start+1..endpoint-1]
    list.[0..start]@ (List.rev piece) @ list.[endpoint..list.Length-1]


[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите список: ")
    let n = Convert.ToInt32(Console.ReadLine())
    let list= ReadList n
    WriteList(Result_List list)
    0