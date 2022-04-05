open System

let Otvet k =    
    match k with 
    |1|2 -> System.Console.WriteLine("Подлиза...")
    |3 -> System.Console.WriteLine("А ты вообще программист?")
    |4 -> System.Console.WriteLine("Да Вы эстет, я полагаю")
    |5 -> System.Console.WriteLine("Кто ты, Воин?..")
    | _ ->System.Console.WriteLine("Хм...Ваше право")
[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Какой ваш любимый язык программирования?
    1 F#
    2 Prolog
    3 HTML
    4 Pascal
    5 Assembler
    6 C++
    7 Java")
    let k=System.Convert.ToInt32(System.Console.ReadLine())
    Otvet k 
    0 
