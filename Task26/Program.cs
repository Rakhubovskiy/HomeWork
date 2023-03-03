// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumNumbers(N, M));

int SumNumbers(int end, int start)
{
    if (start == end)
    {
        return start;
    }
    else
    {
        return start + SumNumbers(end, start + 1);
    }
}
