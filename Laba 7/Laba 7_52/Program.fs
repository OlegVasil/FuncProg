open System
let rec ReadList n =
    List.init(n) (fun index->Convert.ToDouble(Console.ReadLine()))

let rec WriteList list=
    List.iter(fun x->printfn "%O" x) list

let Simple number =
    let rec simp num del =
        if num <= 1 then []
        else 
            let new_del = del+1
            if num % del =0 then List.append[del] (simp (num/del) del)                        
            else simp num new_del  
    simp number 2 

[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите ваше число: ")
    let number = System.Convert.ToInt32(System.Console.ReadLine())
    WriteList(Simple number)
    0