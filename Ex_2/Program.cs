// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumsInNumber(int n)
{
    int sum = 0;
    if (n == 0) return sum;

    if (n / 10 == 0)
    {
        sum = n;
    }
    else
    {
        while (n != 0)
        {
            sum += n % 10;
            n = n / 10;
        }
    }
    return sum;
}

System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Сумма цифр в числе {N} равна: {SumNumsInNumber(N)}!");