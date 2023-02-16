// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Сумма элементов на нечётных позициях: {SumArray(array)}");

void FillArray(int[] fillArray)
{
    int length = fillArray.Length;
    for (int index = 0; index < length; index++)
    {
        fillArray[index] = new Random().Next(-99, 100);
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

int SumArray(int[] sumArray)
{
    int sum = 0;
    int length = sumArray.Length;
    for (int index = 0; index <= length; index++)
    {
        if (index % 2 > 0)
        {
            sum = sum + sumArray[index];
        }
    }
    return sum;
}