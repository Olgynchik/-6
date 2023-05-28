// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FirstLine(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double SecondLine(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
double FindX(double k1, double b1, double k2, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

double FindY(double k1, double b1, double x)
{
    return k1 * x + b1;
}

double b1 = FirstLine("b1: ");
double b2 = SecondLine("b2: ");
double k1 = FirstLine("k1: ");
double k2 = SecondLine("k2: ");

double x = FindX(k1, b1, k2, b2);
double y = FindY(k1, b1, x);

Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");