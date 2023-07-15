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
int i = FillArray("Введите последовательность чисел для заполнения массива, когда закончите - введите 'end'", userArray);
PrintArray(i, userArray);
