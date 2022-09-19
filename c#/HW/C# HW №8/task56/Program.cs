// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    int minSum = 0;
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = sumLine(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSum = i;
        }
    }
    return minSum;
}

    /* void MinElementLine(int num)
    {
        int minSumLine = 0;
        int sumLine = SumLineElements(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int tempSumLine = SumLineElements(array, i);
            if (sumLine > tempSumLine)
            {
                sumLine = tempSumLine;
                minSumLine = i;
            }
        }
    } */

    Console.WriteLine("Введите значение m: ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение n: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение min: ");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение max: ");
    int max = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Введённый массив: ");


    int[,] myArray = GetArray(m, n, min, max);
    PrintArray(myArray);
    int sumLine = SumLineElements(myArray, 0);
    Console.WriteLine("_________");
    Console.WriteLine(sumLine);


/* 
Console.WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов "); */