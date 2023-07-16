// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumOddElements(int[] array)
{
    int oddSum = 0;
    for(int i = 1;  i < array.Length; i+=2)
    {
           oddSum += array[i]; 
    }
    return oddSum;
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

int[] array = MakeNewRandomArray(15, -100, 100);
Console.WriteLine($"[{string.Join(",", array)}] -> {SumOddElements(array)}");