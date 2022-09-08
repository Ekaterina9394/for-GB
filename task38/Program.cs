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

double[] MinArray(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        num = array[i];

        if (num <= min)
            min = num;
         
    }
        
    return min;
}

double[] myArray = GetArray(5, -10, 10);
Console.WriteLine(String.Join(" ", myArray));
double[] result = MinArray(myArray);
Console.WriteLine(String.Join(" ", result));
