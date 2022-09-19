// Задайте двумерный массив. Напишите программу, которая заменяет 
//строки на столбцы. В случае, если это невозможно, программа
// должна вывести сообщение для пользователя

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

int[,] SwapRowsAndColums(int[,] array)
{
    int[,] tempArray = new int[array.GetLength(0), array.GetLength(1)];
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                tempArray[j, i] = array[i, j];
            }
        }
        return tempArray;
    }
    else
    {
        Console.WriteLine("Невозможно поменять местами");
        return array;
    }
}

Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение max: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение min: ");
int min = int.Parse(Console.ReadLine());


int[,] myArray = GetArray(m, n, max, min);
PrintArray(myArray);
Console.WriteLine();
int[,] changedArray = SwapRowsAndColums(myArray);
PrintArray(changedArray);