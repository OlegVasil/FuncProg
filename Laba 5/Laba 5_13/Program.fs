open System

//ВВЕРХ

let rec mult_1 x =    // произведение цифр
    if x = 0 then 1
    else (x % 10)*mult_1(x / 10)

let rec max_1 x = //максимальная цифра
    if x<10 then x
    else max (x % 10) (max_1 (x/10))

let rec min_1 x = //минимальная цифра
    if x<10 then x
    else min (x % 10) (min_1 (x/10))

//ВНИЗ

let mult_2 x = //произведение цифр
    let rec pr1 x init =
        if x = 0 then init
        else 
            let p = x % 10
            let ost = x / 10
            let proizvedenie = p* init 
            pr1 ost proizvedenie 
    pr1 x 1


let max_2 x = //максимальная цифра
    let rec max2 x init =
        if x=0 then init 
        else 
            let p = x % 10
            let new_max = if p> init then p else init
            let ost = x / 10                      
            max2 ost new_max
    max2 x (x % 10)      
    
let min_2 x = //минимальная цифра
    let rec min2 x init = 
        if x=0 then init
        else
            let p = x % 10
            let new_min = if p< init then p else init
            let ost = x / 10                      
            min2 ost new_min
    min2 x (x%10)               

[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Введите ваше число:")
    let x = System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine("Рекцурсия вверх:")
    System.Console.WriteLine("Произведение цифр:{0}", mult_1 x)
    System.Console.WriteLine("Максимальная цифра:{0}", max_1 x)
    System.Console.WriteLine("Минимальная цифра:{0}", min_1 x)
    System.Console.WriteLine("Рекцурсия вниз:")
    System.Console.WriteLine("Произведение цифр:{0}", mult_2 x)
    System.Console.WriteLine("Максимальная цифра:{0}", max_2 x)
    System.Console.WriteLine("Минимальная цифра:{0}", min_2 x)
    0