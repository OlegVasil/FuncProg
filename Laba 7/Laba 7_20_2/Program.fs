open System

let SortBySize arrStr =
    let rec sort (str:string) ind (summ:int)=

        if (ind = str.Length) then Convert.ToDouble(summ)/Convert.ToDouble(str.Length) // Сумма кода делится на кол-во символов
        else
            sort str (ind+1) (summ + Convert.ToInt32(str.[ind])) // Прибавляем ASCII

    Array.sortBy (fun (str:string) -> sort str 0 0) arrStr

let WriteArray arr = 
    let rec write (arr : 'T [] ) (ind : int)=
        if (ind = arr.Length) then ()
        else
            Console.WriteLine( arr.[ind] )
            write arr (ind+1)
    write arr 0


[<EntryPoint>]
let main argv =
    Console.WriteLine( "Введите количество строк: " )
    let num = Convert.ToInt32(Console.ReadLine())

    Console.WriteLine( "Введите ваши строки: " )
    let strArr = [| for i in 1..num -> Convert.ToString(Console.ReadLine()) |]

    Console.WriteLine("Строки, отсортированные по увеличению среднего веса ASCII-кода символа в строке" )
    WriteArray(SortBySize strArr)

    0