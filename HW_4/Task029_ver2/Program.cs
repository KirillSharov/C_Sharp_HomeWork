// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int i, int[] array)
{
    Console.Write("[");
    for (int k = 0; k < i-1; k++)
    {
        Console.Write($"{array[k]}, ");
    }
    Console.Write($"{array[i - 1]}]");
}

int FillArray(string message, int[] array)
{
    string userElement;
    int i = 0;
    Console.WriteLine(message);
    while ((userElement = Console.ReadLine()) != "end")
    {
        array[i++] = Convert.ToInt32(userElement);
    }
    return i;
}

int[] userArray = new int[100];
int arrayElementCount = FillArray("Введите последовательность чисел для заполнения массива, когда закончите - введите 'end'", userArray);
PrintArray(arrayElementCount, userArray);
