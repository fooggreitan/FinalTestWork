// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Напишите числа через запятую!");

string[] arr = Console.ReadLine().Split(", ");       

string[] Rep(string[] text)
{ 
    string[] newP = new string[text.Length]; 
    
    for (int i = 0; i < text.Length; i++)
    {
        int lenght = text[i].Length; 

        if (lenght <= 3) 
        {
            newP[i] = text[i];
        }
    }

    return newP;
}

void PrintArray(string[] array) 
{

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == null) Console.Write($"{array[i]}");
        else if (i < array.Length - 2 && array[i] != null) Console.Write($"{array[i]}, ");
        else if (i < array.Length - 1 && array[i+1] != null) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

PrintArray(arr);
Console.Write(" -> ");

string[] rep = Rep(arr);
PrintArray(rep);