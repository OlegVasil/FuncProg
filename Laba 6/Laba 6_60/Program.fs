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

let Freq list temp = 
    let rec freq list temp count = 
        match list with 
        | []-> count 
        | h::t ->
            if h=temp then
             freq t temp (count+1)
            else freq t temp count 
    freq list temp 0 

let NewList list =
    let rec newlist templist list resultlist index =
        match list with
        | h::t->
            let newIndex=index+1
            if ((h%newIndex=0) && ((Freq templist h)=1)) then newlist templist t (resultlist @[h]) newIndex
            else newlist templist t resultlist newIndex
        | []-> resultlist
    newlist list list [] 0

[<EntryPoint>]
let main argv = 
    Console.WriteLine("Введите массив: ")
    let n = Convert.ToInt32(Console.ReadLine())
    let list = ReadList n 
    Console.WriteLine("Массив: ")
    let result = NewList list
    Console.WriteLine(WriteList result) //Console.WriteLine(NewList list)
    0
