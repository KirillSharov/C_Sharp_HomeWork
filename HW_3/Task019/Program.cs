// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Palindrome(string num)
{
    char[] arrayNum = num.ToCharArray();
    if (arrayNum[0] == arrayNum[4] & arrayNum[1] == arrayNum[3]) return "да";
    else return "нет";
}

string GetInfo (string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string num = GetInfo("Введите пятизначное число: ");
Console.WriteLine($"{num} -> {Palindrome(num)}");