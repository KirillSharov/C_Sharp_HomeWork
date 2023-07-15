// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation (int firstNum, int secondNum)
{
    int powerA = (int)Math.Pow(firstNum, secondNum);
    return powerA;
}

int GetInfo (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int A = GetInfo("Введите первое число: ");
int B = GetInfo("Введите второе число: ");
Console.WriteLine($"{A}, {B} -> {Exponentiation(A, B)}");