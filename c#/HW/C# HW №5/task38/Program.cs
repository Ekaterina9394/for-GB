// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76




double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToDouble(new Random().Next(minValue, maxValue)) + new Random().NextDouble();
    }
    return res;
}

 double MaxNum(double[] Array)
{
    double max = Array[0];
    for (int index = 0; index < Array.Length; index++)
    {
        if (Array[index] > max)
            max = Array[index];
    }
    return max;
}

 double MinNum(double[] Array)
{
    double min = Array[0];
    for (int index = 0; index < Array.Length; index++)
    {
        if (Array[index] < min)
            min = Array[index];
    }
    return min;
}

double[] myArray = GetArray(5, 10, 100);
Console.WriteLine(String.Join(" ", myArray));
double result = MaxNum(myArray) - MinNum(myArray);
Console.WriteLine($"Разница -> {result:f2}");