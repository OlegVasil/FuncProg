open System
 //локальный максимум - элемент, больше двух "соседних".
let rec ReadList n =
    List.init(n) (fun index->Convert.ToDouble(Console.ReadLine()))

let rec WriteList list=
    List.iter(fun x->printfn "%O" x) list

let Result_List list= List.filter (fun x->x<List.average list) list

[<EntryPoint>]
let main argv =

    Console.WriteLine("Введите список: ")
    let n = Convert.ToInt32(Console.ReadLine())
    let list= ReadList n
    Console.WriteLine("Результат: ")
    Console.WriteLine(Result_List list)
    0