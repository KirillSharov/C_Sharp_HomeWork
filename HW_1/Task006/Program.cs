// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");

int userNum = int.Parse(Console.ReadLine());

if (userNum % 2 == 0)
{
    Console.WriteLine($"Число {userNum} - чётное");
}
else
{
    Console.WriteLine($"Число {userNum} - нечётное");
}
