// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите последовательно три числа. После ввода каждого числа нажмите клавишу 'ENTER'");
int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
int thirdNum = int.Parse(Console.ReadLine());

int maxNum = firstNum;

if (secondNum > maxNum)
{
     maxNum = secondNum;
}
    if (thirdNum > maxNum)
    {
        maxNum = thirdNum;
    }

Console.WriteLine($"Из чисел: {firstNum}, {secondNum}, {thirdNum} максимальное - {maxNum}");

