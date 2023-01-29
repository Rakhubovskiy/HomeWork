// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Insert the number: ");
int N = int.Parse(Console.ReadLine());
int start = 2;
if (N < 0) N = N * -1;
if (N == -1) N = N + 3;
if (N == 0) N = N + 2;
if (N == 1) N = N + 1;
while (start <= N)
{
    Console.Write(start + " ");
    start = start + 2;
}
