// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

string FindPositionInArray(int number, int[,] matr)
{
    int row = 0;
    int col = number;
    if (number < 10)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == number) return $"{number} -> {matr[0, j]}";
        }
    }
    if (number > 10)
    {
        row = number / 10;
        col = number % 10;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (i == row & j == col) return $"{number} -> {matr[i, j]}";
            }
        }
    }
    return $"{number} -> такого числа в массиве нет!";
}

string CheckingNumber(string pos)
{
    if (pos == string.Empty) return "такого числа в массиве нет!";
    else return pos;
}

string FindNumberInArray(int number, int[,] matr)
{
    string position = string.Empty;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == number) position += $" ({i}, {j})";
        }
    }
    return position;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateAndPrintTwoDimentionArray()
{
    int[,] matrix = new int[new Random().Next(3, 10), new Random().Next(3, 10)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}

int[,] matrix = CreateAndPrintTwoDimentionArray();
Console.WriteLine("Чтобы найти позицию числа - введите 'pos', найти число по позиции - введите 'num'.");
string? userRequest = Console.ReadLine();
if (userRequest == "pos")
{
    int findPosition = GetInfo("Введите число, позицию которого хотите найти: ");
    string allPositionNumberInArray = FindNumberInArray(findPosition, matrix);
    Console.WriteLine($"{findPosition} -> {CheckingNumber(allPositionNumberInArray)}");
}

if (userRequest == "num")
{
    int findNumber = GetInfo("Введите позицию числа, которое хотите найти: ");
    Console.WriteLine(FindPositionInArray(findNumber, matrix));
}