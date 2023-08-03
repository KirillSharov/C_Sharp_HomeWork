// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

static bool CheckDuplicate(int[,,] array, int number)
{
    foreach (int element in array)
    {
        if (element == number)
        {
            return true; // Если число уже есть в массиве, возвращаем true
        }
    }
    return false; // Число не найдено в массиве, возвращаем false
}

void PrintThreeDimensionalArray(int[,,] matr, int N)
{
    Console.WriteLine($"Массив размером {N} x {N} x {N}: ");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] FillThreeArray(int N)
{
    int[,,] array = new int[N, N, N];
    Random rand = new Random();
    int randomNumber;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < N; k++)
            {
                bool isDuplicate;
                do
                {
                    randomNumber = rand.Next(10, 100);
                    isDuplicate = CheckDuplicate(array, randomNumber); //Проверка повторения числа
                } while (isDuplicate);
                array[i, j, k] = randomNumber;
            }
        }
    }
    return array;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = GetInfo("Введите число: ");

int[,,] threeDimention = FillThreeArray(N);
PrintThreeDimensionalArray(threeDimention, N);