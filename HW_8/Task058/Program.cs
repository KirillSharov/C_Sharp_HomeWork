// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MatrixMultiplication(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] result = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            for (int k = 0; k < matrixSecond.GetLength(0); k++)
            {
                result[i, j] += matrixFirst[i, k] * matrixSecond[k, j];
            }
        }
    }
    return result;
}

void PrintMatrix(string message, int[,] matr)
{
    Console.WriteLine($"{message} ");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MakeNewRandomArray(int m, int n)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 5);
        }
    }
    return matr;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rowsA = GetInfo("Введите количество строк матрицы А: ");
int columnsA = GetInfo("Введите количество столбцов матрицы А: ");
int rowsB = GetInfo("Введите количество строк матрицы В: ");
int columnsB = GetInfo("Введите количество столбцов матрицы В: ");
if (columnsA != rowsB) Console.WriteLine("Матрицы несогласованы! Число столбцов первого сомножителя должно быть равно числу строк второго сомножителя.");
else
{
    int[,] matrixA = MakeNewRandomArray(rowsA, columnsA);
    int[,] matrixB = MakeNewRandomArray(rowsB, columnsB);
    PrintMatrix("Матрица А: ", matrixA);
    PrintMatrix("Матрица B: ", matrixB);
    int[,] resultMatrix = MatrixMultiplication(matrixA, matrixB);
    PrintMatrix("Результирующая матрица: ", resultMatrix);
}
