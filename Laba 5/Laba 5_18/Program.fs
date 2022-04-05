open System 

let NOD x y =
    let rec NOD1 x y i temp= 
        if x+1 = i || y+1 = i then temp
        else 
            if x%i <> 0 || y%i <> 0 then NOD1 x y (i+1) temp
            else 
                let nod = i
                NOD1 x y (i+1) nod
    NOD1 x y 1 1

let PrimeNumber x f init = 
    let rec PrimeNumberProcessing1 x f init current = 
        if current = 0 then init
        else
            let newInit = if NOD x current = 1 then f init current
                          else init
            let newCurrent = current - 1
            PrimeNumberProcessing1 x f newInit newCurrent
    PrimeNumberProcessing1 x f init x

let Euler x = // сумма простх делителей числа
    PrimeNumber x (fun x y-> x + 1) 0

let SimpleCounter x a = 
    let rec Counter x a k = 
        if x=0 then k
        else 
            if NOD (x%10) a = 1 then Counter (x/10) a k+1
            else  Counter (x/10) a k
            
    Counter x a 0

let Summ x  = //сумма цифр числа кратных трем
    let rec Summ x temp = 
        if x=0 then temp
        else if x%10%3=0 then Summ (x/10) (temp+x%10)
        else Summ (x/10) temp
    Summ x 0
            

let SimpleMax x = //делитель числа, взаимно простой с наибольшим кол-вом цифр числа
    let rec SimpleMax x Divider maxCount maxDivider =
        if Divider = 0 then maxDivider
            else if SimpleCounter x Divider > maxCount then
                    let maxCount = SimpleCounter x Divider
                    SimpleMax x (Divider-1) (SimpleCounter x Divider) Divider
                 else 
                    SimpleMax x (Divider - 1) maxCount maxDivider
    SimpleMax x x 0 0


[<EntryPoint>]
let main argv =
    
    Console.WriteLine("Сумма простых делителей числа: {0}", Euler 40)
    Console.WriteLine("Сумма цифр числа, делящихся на 3: {0}", Summ 25339933)
    Console.WriteLine("Делитель числа, взаимно простой с наибольшим количеством цифр числа: {0}", SimpleMax 68)
    0   
