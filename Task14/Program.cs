// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Количество чётных чисел в массиве: {CountArray(array)}");

void FillArray(int[] fillArray)
{
    int length = fillArray.Length;
    for (int index = 0; index < length; index++)
    {
        fillArray[index] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] printArray)
{
    int length = printArray.Length;
    for (int index = 0; index < length; index++)
    {
        Console.Write($"{printArray[index]} ");
    }
}

int CountArray(int[] countArray)
{
    int count = 0;
    int length = countArray.Length;
    for (int index = 0; index < length; index++)
    {
        if (countArray[index] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
