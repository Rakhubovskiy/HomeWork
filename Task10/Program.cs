﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int start = 1;
while (start < N)
{
    Console.Write(start * start * start + ", ");
    start++;
}
Console.Write(start * start * start);