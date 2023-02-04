// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.Write("Ура! Выходной!");
}
else
{
    if (day == 1)
    {
        Console.WriteLine("Monday");
    }
    if (day == 2)
    {
        Console.WriteLine("Tuesday");
    }
    if (day == 3)
    {
        Console.WriteLine("Wednesday");
    }
    if (day == 4)
    {
        Console.WriteLine("Thursday");
    }
    if (day == 5)
    {
        Console.WriteLine("Friday");
    }
    if (day < 1 || day > 7)
    {
        Console.WriteLine("You entered the wrong day");
    }
}
