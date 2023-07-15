// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray()
{
    int[] array = new int[8];
    Console.Write("[");
    for (int i = 0; i < 7; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[7]=new Random().Next(0, 100)}]");
}
FillArray();