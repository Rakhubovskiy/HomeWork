// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = int.Parse(Console.ReadLine());
int result = number;
for (int count = 1; count < degree; count++)
{
    result *= number;
}
Console.Write(result);