open System

let rec ReadList n =
    List.init(n) (fun index->Convert.ToInt32(Console.ReadLine()))

let rec WriteList list=
    List.iter(fun x->printfn "%O" x) list

[<EntryPoint>]
let main argv =
    let array1=[|1;2;3|]
    let array2=[|4;5;7|]
    let result=Array.append array1 [|(Array.item(array2.Length-1) array2)|] 
    printfn"%A"result
    0 
