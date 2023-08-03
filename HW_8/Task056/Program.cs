// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void SortArray(int[] array)
{
    int min = array[0];
    int numMinRow = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            numMinRow = i;
        }
    }
    Console.Write($"Наименьшая сумма элементов в строке {numMinRow + 1}");
}

void PrintTwoDimensionalArray(int[,] matr, int[] array)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.Write($" -> {array[i]}");
        Console.WriteLine();
    }
}

int[] SumRow(int[,] matr)
{
    int[] arraySum = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumRow += matr[i, j];
        }
        arraySum[i] = sumRow;
    }
    return arraySum;
}

int[,] MakeNewRandomArray(int m, int n, int min, int max)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max);
        }
    }
    return matr;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInfo("Введите количество строк: ");
int columns = GetInfo("Введите количество столбцов: ");
int[,] matrix = MakeNewRandomArray(rows, columns, 1, 10);
int[] sumArray = SumRow(matrix);
PrintTwoDimensionalArray(matrix, sumArray);
Console.WriteLine();
SortArray(sumArray);