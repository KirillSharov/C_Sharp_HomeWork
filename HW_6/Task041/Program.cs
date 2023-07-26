// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int SearchAboveZero(int[] array)
{
    int aboveZero = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) aboveZero++;
    }
    return aboveZero;
}

int[] FillArray(int M)
{
    int[] array = new int[M];
    Console.WriteLine($"Заполните массив!");
    for(int i = 0; i < M; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int GetInfo (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int M = GetInfo("Введите количество элемнтов массива: ");
int[] array = FillArray(M);
Console.WriteLine($"{string.Join(", ", array)} -> {SearchAboveZero(array)}");