open System

let rec ReadList n =
    List.init(n) (fun index->Convert.ToInt32(Console.ReadLine()))

let rec WriteList list=
    List.iter(fun x->printfn "%O" x) list

let Order str=
    let lower_str=String.filter(fun ch->Char.IsLower(ch)) str
    let srt_list=Seq.toList(lower_str)
    let result=List.map2(fun ch1 ch2-> ch1<=ch2) srt_list.[0..srt_list.Length-2] srt_list.[1..srt_list.Length-1] 
    if (List.fold (fun s x-> if x=false then s+1 else s) 0 result) = 0 then Console.WriteLine("Упорядочены")
    else Console.WriteLine("Не упорядочены")


[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите строку")
    let str = Console.ReadLine()
    Order str
    0 