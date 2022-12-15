// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetDegree(int A, int B)
{
    int degree = 1;

    for (int i = 0; i < B; i++)
    {
        degree *= A;
    }
    return degree;
}

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetDegree(a, b));