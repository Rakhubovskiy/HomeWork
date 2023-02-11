// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int rev = 0;
int result = 0;
while (number > 0)
{
    rev = number % 10;
    result = result + rev;
    number = number / 10;
}
Console.Write($"Сумма цифр в числе = {result}");