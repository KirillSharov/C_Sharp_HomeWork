// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int num)
{
    Console.Write($"{num} -> ");
    for (int i = 1; i < num; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.WriteLine(Math.Pow(num, 3) + ". ");
}

int GetInfo (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число: ");
Cube(num);