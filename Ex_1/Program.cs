// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными,
// так как задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int XinPowY(int x, int y)
{
    int result = x;
    for (int i = 1; i < y; i++)
    {
        result=result*x;
    }
    return result;
}

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"{A} в степени {B} равно {XinPowY(A,B)}");