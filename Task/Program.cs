// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.

// **Примеры**:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


//Ввод данных с клавиатуры и сохранение в массив
string[] InsertMass()
{
    int count = 0;
    string word;
    string[] arr = new string[count];
    string[] arr2;

    while (true)
    {
        Console.Write("Введите что-нибудь: ");
        word = Console.ReadLine();
        if (word == "") return arr;
        else
        {
            count++;
            arr2 = new string[count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            arr2[count - 1] = word;
            arr = arr2;
        }
    }
}

//Печать заданного массива (не обязательная часть)
void PrintArray(string[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}
// Из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа
void ShortArray(string[] array)
{
    int count = array.Length;
    Console.Write($"[");
    for (int i = 0; i < count; i++)
    {
        if (array[i].Length < 4)
            Console.Write($"'{array[i]}' ");
    }
    Console.Write($"]");
    Console.WriteLine();
}
//Вывод варианта, где массив задается на старте выполнения алгоритма

string[] arrtest1 = { "hello", "2", "world", ":-)" };
PrintArray(arrtest1);
ShortArray(arrtest1);

string[] arrtest2 = { "1234", "1567", "-2", "computer science" };
PrintArray(arrtest2);
ShortArray(arrtest2);

string[] arrtest3 = { "Russia", "Denmark", "Kazan" };
PrintArray(arrtest3);
ShortArray(arrtest3);

//Вывод варианта, где массив вводится с клавиатуры

ShortArray(InsertMass());
