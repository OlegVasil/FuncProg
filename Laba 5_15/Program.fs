open System

let rec Func a b =
    if a=b then a
    else 
        if a>b then Func (a-b) b 
        else Func a (b-a) 

let Obhod x F init =
    let rec obhod x F init number =
        if number=0 then init
        else 
            if (Func x number) = 1 then obhod x F (F init number) (number-1)
            else obhod x F init (number-1)   
    obhod x F init x
          

[<EntryPoint>]
let main argv =
    System.Console.Write("Введите ваше число: ")
    let x = System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine("Произведение:{0}", Obhod x (fun x y -> x*y) 1)
    0 