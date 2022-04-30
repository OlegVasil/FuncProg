open System
 
let rec ReadList n =
    List.init(n) (fun index->Convert.ToInt32(Console.ReadLine()))

let rec WriteList list=
    List.iter(fun x->printfn "%O" x) list

let Result_List (list:'int list)=List.fold (fun s x->if x then s+1 else s) 0 (List.map3 (fun x y z->(y>x)&&(y>z)) list.[0..list.Length-3] list.[1..list.Length-2] list.[2..list.Length-1]) 

[<EntryPoint>]
let main argv =

    Console.WriteLine("Введите список: ")
    let n = Convert.ToInt32(Console.ReadLine())
    let list= ReadList n
    Console.WriteLine("Результат: ")
    Console.WriteLine(Result_List list)
    0