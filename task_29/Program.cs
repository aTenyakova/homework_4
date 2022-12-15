// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetArray()
{
    int size = 8;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int[] resultArray = GetArray();
Console.WriteLine($"[{String.Join(", ", resultArray)}]");