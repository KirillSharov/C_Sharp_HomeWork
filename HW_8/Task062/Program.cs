// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int N)
{
    int[,] array = new int[N, N];
    int currentValue = 1;
    int rowStart = 0;
    int rowEnd = N;
    int colStart = 0;
    int colEnd = N;
    while (currentValue <= N * N)
    {
        for (int i = colStart; i < colEnd; i++)
        {
            array[rowStart, i] = currentValue++;
        }
        rowStart++;

        for (int i = rowStart; i < rowEnd; i++)
        {
            array[i, colEnd - 1] = currentValue++;
        }
        colEnd--;

        for (int i = colEnd - 1; i >= colStart; i--)
        {
            array[rowEnd - 1, i] = currentValue++;
        }
        rowEnd--;

        for (int i = rowEnd - 1; i >= rowStart; i--)
        {
            array[i, colStart] = currentValue++;
        }
        colStart++;
    }
    return array;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = GetInfo("Введите размер массива: ");
int[,] array = FillArray(N);
PrintArray(array);