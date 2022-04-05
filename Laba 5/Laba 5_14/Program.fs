open System

let DivCounter x f init = // данная программа вычисляет произведение делителей числа
    let rec Counter x f init currentDivider = 
        if currentDivider = 0 then init
        else 
            if x % currentDivider = 0 then 
                let newInit = f init currentDivider 
                let newDivider = currentDivider - 1
                Counter x f newInit newDivider
            else  
                let newDivider = currentDivider - 1
                Counter x f init newDivider
    Counter x f init x




[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Введите ваше число: ")
    let i = System.Convert.ToInt32(System.Console.ReadLine())
    Console.WriteLine("Ответ:{0}", DivCounter i (fun x y -> x * y) 1)
    0 