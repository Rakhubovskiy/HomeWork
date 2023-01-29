// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Insert the number A = ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Insert the number B = ");
int numberB = int.Parse(Console.ReadLine());
int max = numberA;
int min = numberB;
if (max > min)
{
    Console.WriteLine("Maximum number = " + max);
    Console.WriteLine("Minimum number = " + min);
}
if (min > max)
{
    Console.WriteLine("Maximum number = " + min);
    Console.WriteLine("Minimum number = " + max);
}