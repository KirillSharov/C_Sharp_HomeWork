// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PointIntesectionLines(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 < 0 & b2 < 0)
        {
            Console.WriteLine($"Прямые y={k1}*x{b1} и y={k2}*x{b2} параллельны!");
        }
        else if (b1 < 0)
        {
            Console.WriteLine($"Прямые y={k1}*x{b1} и y={k2}*x+{b2} параллельны!");
        }
        else if (b2 < 0)
        {
            Console.WriteLine($"Прямые y={k1}*x+{b1} и y={k2}*x{b2} параллельны!");
        }
        else
        {
            Console.WriteLine($"Прямые y={k1}*x+{b1} и y={k2}*x+{b2} параллельны!");
        }
    }
    else
    {
        double x = Math.Round(-(b1 - b2) / (k1 - k2), 5);
        double y = Math.Round((k2 * x) + b2, 5);
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}, {y})");
    }
}

double GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = GetInfo("Первая прямая y = k1 * x + b1. Введите коэффициент b1: ");
double k1 = GetInfo("Введите коэффициент k1: ");
double b2 = GetInfo("Вторая прямая y = k2 * x + b2. Введите коэффициент b2: ");
double k2 = GetInfo("Введите коэффициент k2: ");
PointIntesectionLines(b1, k1, b2, k2);