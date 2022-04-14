open System

let rec ReadList n = 
    if n=0 then []
    else 
    let Head = Convert.ToInt32(Console.ReadLine()) 
    let Tail = ReadList (n-1)
    Head::Tail


let Max list =
    let rec find_max_r list current_max max_idx current_idx =
        match list with
        | [] -> (max_idx, current_max)
        | h::t ->
            let new_max = if h > current_max then h else current_max
            let new_max_idx = if h > current_max then current_idx else max_idx
            let new_idx = current_idx + 1
            find_max_r t new_max new_max_idx new_idx
    find_max_r list list.Head 0 0

let pr a b max = 
    if (max>=b || max<=a ) then false
    else true

[<EntryPoint>]
let main argv = 
    Console.WriteLine("Введите массив: ")
    let n = Convert.ToInt32(Console.ReadLine())
    let list = ReadList n
    let max= Max list 
    let max1=snd max
    Console.WriteLine("Введите интервал: ")
    Console.Write("a: ")
    let a = Convert.ToInt32(Console.ReadLine())
    Console.Write("b: ")
    let b = Convert.ToInt32(Console.ReadLine())
    Console.WriteLine(pr a b max1)
    0