// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.

// **Примеры**:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

//Массив задается на старте выполнения алгоритма

string[] CountNum()
{
    int count = 0;
    string word;
    string[] arr = new string[count];
    while (true)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write("Введите любое число: ");
            word = Console.ReadLine();

            if (word == "") return arr;
            else
            {
                count++;
                arr[i] = word;

            }

        }
    }

}




// string[] arr = { "hello", "2", "world", ":-)" };

void PrintArray(string[] array)
{
    int count = array.Length;
    Console.Write($"['{array[0]}', ");
    for (int i = 1; i < count - 1; i++)
    {
        Console.Write($"'{array[i]}', ");
    }

    Console.Write($"'{array[count - 1]}']");

    Console.WriteLine();
}

// void ShortArray(string[] array)
// {
//     int count = array.Length;
//     Console.Write($"[");
//     for (int i = 0; i < count; i++)
//     {
//         if (array[i].Length < 4)
//             Console.Write($"'{array[i]}', ");
//     }
//     Console.Write($"]");
//     Console.WriteLine();
// }

// PrintArray(arr);
// ShortArray(arr);


CountNum();
PrintArray(CountNum());