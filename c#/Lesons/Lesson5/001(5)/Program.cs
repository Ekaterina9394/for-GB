// задайте массив из 12 элементов наполненный случайными числами
//из промежутка (-9;9). Найдите сумму отриц и полож
//элементов массива
//например (3,9,-8,1,0,-7,2,-1,8,-3,-1,6)сумма полож
//чисел равна 29, сумма отриц -20

// как сгенерировать массив
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] PositiveAndNegativeSum(int[] array)
{
    int[] res = new int[2];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            res[0] += array[i];
        }
        else
        {
            res[1] += array[i];
        }
    }
    return res;
}

// как легче найти и сложить отриц и полож числа

void PositiveSum(int[]array)
{
    int positiveSum = 0;

    foreach(int el in array)
    {
        positiveSum += el > 0 ? el : 0;
    }
    Console.WriteLine($"{positiveSum}");
}


int[] myArray = GetArray(10, -100, 100);
int[] result = PositiveAndNegativeSum(myArray);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine(String.Join(" ", result));
PositiveSum(myArray);