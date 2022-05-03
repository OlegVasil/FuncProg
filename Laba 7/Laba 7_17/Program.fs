open System
let rec ReadList n =
    List.init(n) (fun index->Convert.ToInt32(Console.ReadLine()))

let rec WriteList list=
    List.iter(fun x->printfn "%O" x) list

let Result list=
    (List.map (fun x->x/2) (List.filter (fun x->x%2=0) list) , List.map (fun x->x/3) (List.filter (fun x->x%3=0) list),
        List.map (fun x-> x*x )(List.map (fun x->x/3) (List.filter (fun x->x%3=0) list)), 
            List.filter (fun x-> List.contains(x) (List.map (fun x->x/2) (List.filter (fun x->x%2=0) list))) (List.map (fun x-> x*x )(List.map (fun x->x/3) (List.filter (fun x->x%3=0) list))),
                List.map (fun x->x/3) (List.filter (fun x->x%3=0) list) @ List.map (fun x-> x*x )(List.map (fun x->x/3) (List.filter (fun x->x%3=0) list)) @ List.filter (fun x-> List.contains(x) (List.map (fun x->x/2) (List.filter (fun x->x%2=0) list))) (List.map (fun x-> x*x )(List.map (fun x->x/3) (List.filter (fun x->x%3=0) list))))

let Unpack tuple idx =
    match idx, tuple with
    | 0, (a,_,_,_,_) -> a
    | 1, (_,b,_,_,_) -> b
    | 2, (_,_,c,_,_) -> c
    | 3, (_,_,_,d,_) -> d
    | 4, (_,_,_,_,e) -> e
    | _, _ -> failwith (sprintf "Несуществующий индекс %i" idx) 

let WriteResult tuple= 
    let rec wtr tuple index=
        if index<5 then 
            Console.WriteLine("Список номер {0}:",index+1)
            WriteList(Unpack tuple index)
            let new_index=index+1
            wtr tuple new_index
    wtr tuple 0

[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите список: ")
    let n = Convert.ToInt32(Console.ReadLine())
    let list= ReadList n
    let r=Result list
    WriteResult r
    0