// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Insert the number A = ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Insert the number B = ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Insert the number C = ");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine("Maximum number = " + max);