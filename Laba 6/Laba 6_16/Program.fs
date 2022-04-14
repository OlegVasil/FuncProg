open System
let rec ReadList n = 
    if n=0 then []
    else 
    let Head = Convert.ToInt32(Console.ReadLine()) 
    let Tail = ReadList (n-1)
    Head::Tail



let rec WriteList = function
    []->()
    | (head:int)::tail -> 
                Console.WriteLine(head)
                WriteList tail



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




let Max_2 list max2=
    let rec find_max_r list max2 current_max max_idx current_idx =
        match list with
        | [] -> (max_idx, current_max)
        | h::t ->
            let new_max = if (h > current_max && h<>max2) then h else current_max
            let new_max_idx = if (h > current_max && h<>max2) then current_idx else max_idx
            let new_idx = current_idx + 1
            find_max_r t max2 new_max new_max_idx new_idx
    find_max_r list max2 list.Head 0 0 



[<EntryPoint>]
let main argv =
    let n = Convert.ToInt32(Console.ReadLine())
    let list = ReadList n
    let max1= Max list
    let max1_v=snd max1
    let max1_i=fst max1
    let max2=Max_2 list max1_v
    let max2_v=snd max2
    let max2_i=fst max2

    Console.WriteLine("Первый максимум:{0} ",max1)
    Console.WriteLine("Второй максимум:{0} ",max2)
    let start=Math.Min(max1_i,max2_i)
    let endpoint=Math.Max(max1_i,max2_i)
    Console.WriteLine("Ответ: ")
    let result=list.[start+1..endpoint-1]
    WriteList (result)
    0 
