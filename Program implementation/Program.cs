// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Напишите числа через запятую!");

string[] array = Console.ReadLine().Split(", ");       

string[] DesiredArrayDimension(string[] arr)
{ 
    string[] newarray = new string[arr.Length]; 
    
    for (int i = 0; i < newarray.Length; i++)
    {
        int size = arr[i].Length; 

        if (size <= 3) 
        {
            newarray[i] = arr[i];
        }
    }
    
    return newarray;
}

void PrintArray(string[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == null) Console.Write($"{arr[i]}");
        else if (i < arr.Length - 2 && arr[i] != null) Console.Write($"{arr[i]}, ");
        else if (i < arr.Length - 1 && arr[i+1] != null) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

PrintArray(array);

Console.Write(" -> ");

string[] desiredArrayDimension = DesiredArrayDimension(array);
PrintArray(desiredArrayDimension);