open System

let rec ReadList n =
    List.init(n) (fun index->Convert.ToInt32(Console.ReadLine()))

let rec WriteList list=
    List.iter(fun x->printfn "%O" x) list

let Path str=
    let rec m1 (str: string) iter ind =
        if (ind = -1) then str
        else
            if (int(str.[ind]) = iter) then str.[(ind+1)..]
            else m1 str iter (ind-1)
    let rec m2 (str: string) iter ind =
        if (ind = str.Length) then str
        else
            if (int(str.[ind]) = iter) then str.[..(ind-1)]
            else m2 str iter (ind+1)
    let justFile = m1 str (int('\\')) (str.Length-1)
    let file=m2 justFile (int('.')) 0
    Console.WriteLine(file)

[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите строку")
    let str = Console.ReadLine()
    Path str
    0 