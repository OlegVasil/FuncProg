open System

let Otvet (k:string) =    
    match k with 
    |"F#"|"Prolog" -> "Подлиза..."
    | _ -> "Хм...Ваше право"
[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Какой ваш любимый язык программирования?")
    (Console.ReadLine>>Otvet>>Console.WriteLine)()//суперпозиция
    System.Console.WriteLine("Какой ваш любимый язык программирования?")
    let F y x z =z(x(y()))
    F Console.ReadLine Otvet Console.WriteLine //каррирование
    0 
