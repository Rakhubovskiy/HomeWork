// Задайте значение N.
// Напишите программу, которая выведет все натуральные (чётные) числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

NaturalNumbers(1, N);

void NaturalNumbers(int end, int num)
{
    if (num % 2 == 0)
    {
        Console.Write($"{num} ");
    }
    if (num == end)
    {
        return;
    }
    else
    {
        NaturalNumbers(end, num - 1);
    }
}