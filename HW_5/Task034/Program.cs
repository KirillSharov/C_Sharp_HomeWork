// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int EvenNumberCounting(int[] array)
{
    int count = 0;
    for(int i = 0;  i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
           count++; 
        }
    }
    return count;
}

int[] MakeNewRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int[] array = MakeNewRandomArray(15, 100, 1000);
Console.WriteLine($"[{string.Join(",", array)}] -> {EvenNumberCounting(array)}");