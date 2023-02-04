// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты Xa: ");
double Xa = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Ya: ");
double Ya = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Za: ");
double Za = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Xb: ");
double Xb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Yb: ");
double Yb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Zb: ");
double Zb = double.Parse(Console.ReadLine()!);
double AB = Math.Round(Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya) + (Zb - Za) * (Zb - Za)), 2);
Console.WriteLine($"Расстояние между координатами {AB}");
