/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
Ограничения:
- Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
- Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода
*/

Console.Write("Введите элементы через запятую ");
string array = Console.ReadLine()!;

int [] StringToArray(string array)
{
    string[] newarray = array.Split(',');
    int length = newarray.Length;
    int[] numbers = new int [length];
    for (int i = 0; i < newarray.Length; i++)
    {
        numbers[i] = Convert.ToInt32(newarray[i]);
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    int[]  newarray = numbers;
    int count = newarray.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(newarray[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
} 

int [] numbers = StringToArray(array);
PrintArray(numbers);

/*
Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-N");
Console.Write("Введите любое число (N): ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(length);

int[] NewArray(int length)
{
    array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next();
    }
    return array;
}



void PrintArry(int[] array)
{
    int count = array.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(array[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
} 

NewArray(length);
PrintArry(array);*/