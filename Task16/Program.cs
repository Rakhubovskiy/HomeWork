// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] array = new double[5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
double max = 0;
foreach (double el in array)
{
    if (el > max)
    {
        max = el;
    }
}
Console.Write(max);
Console.WriteLine();
double min = max;
foreach (double el in array)
{
    if (el < min)
    {
        min = el;
    }
}
Console.Write(min);
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементом массива: {max - min}");



void FillArray(double[] fillArray)
{
    int length = fillArray.Length;
    for (int index = 0; index < length; index++)
    {
        fillArray[index] = new Random().Next(1, 100);
    }
}

void PrintArray(double[] printArray)
{
    int length = printArray.Length;
    for (int index = 0; index < length; index++)
    {
        Console.Write($"{printArray[index]} ");
    }
}
