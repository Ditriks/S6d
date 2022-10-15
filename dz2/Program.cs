// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите точку k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
 
double x = (b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Прямые пересекуться в точке: ({x};{y})");
