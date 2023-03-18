// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int[] FillMass()
{
    int[] array = new int[8];
    for (int i =0;i<8;i++)
    {
        array[i]=new Random().Next(100);
    }
    return array;
}
int[] array = FillMass();
System.Console.WriteLine($"Полученный массив: [{String.Join(", ",array)}]");