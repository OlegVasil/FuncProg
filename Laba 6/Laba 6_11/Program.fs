open System

let rec ReadList n = 
    if n=0 then []
    else 
    let Head = Convert.ToInt32(Console.ReadLine()) // Console.ReadLine()|>Convert.ToInt32 каррирование наоборот. Эти функции одинаковы.
    let Tail = ReadList (n-1)
    Head::Tail

let rec WriteList = function
    []->()
    | (head:int)::tail -> 
                Console.WriteLine(head)
                WriteList tail

let Summ a b c = (a+b)+c

let Mod (list:'int list) = 
    let rec Mod_1 list (result:'int list)=
        match list with
        | a::b::c::d-> Mod_1 d (result @ [Summ a b c]) 
        | a::b::[]->(result @ [Summ a b 1])
        | a::[]-> (result @ [Summ a 1 1])
        | []->result
    Mod_1 list List.Empty

[<EntryPoint>]
let main argv =
    let n = Convert.ToInt32(Console.ReadLine())
    let list = ReadList n 
    WriteList (Mod list)
    0 