// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double FindMaxOrMinNum(double[] array, bool maxOrMin)
{
    double result = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxOrMin)
        {
            if (array[i] > result)
            {
                result = array[i];
            }
        }
        else
        {
            if (array[i] < result)
            {
                result = array[i];
            }
        }
    }
    return result;
}

double[] MakeNewRandomArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return array;
}
double[] array = MakeNewRandomArray(12);
double variance = FindMaxOrMinNum(array, true) - FindMaxOrMinNum(array, false);
Console.Write($"[{string.Join(", ", array)}]");
Console.WriteLine($" => {FindMaxOrMinNum(array, true)} - {FindMaxOrMinNum(array, false)} = {variance}");
