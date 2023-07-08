// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру от 1 до 7: ");
int numDay = int.Parse(Console.ReadLine());
if (numDay == 6 || numDay == 7)
{
    Console.WriteLine($"{numDay} -> да");
}
else
{
    Console.WriteLine($"{numDay} -> нет");
}
