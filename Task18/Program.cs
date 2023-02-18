// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = InPut();
double k1 = InPut();
double b2 = InPut();
double k2 = InPut();

double x = (b1 - b2) / (k2 - k1); ;
double y = k2 * ((b1 - b2) / (k2 - k1)) + b2;

Console.Write($"Координата x: {x}; Координата y: {y}");

double InPut()
{
    Console.Write("Введите число: ");
    double result = double.Parse(Console.ReadLine()!);
    return result;
}
