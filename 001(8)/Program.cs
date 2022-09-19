// Зададйте двумерный массив. Напишите программу, которая
// поменяет местами первую и последнюю строку массива

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

int[,] Swap1andLastRow(int[,] array)
{
    int lastRowIndex = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[lastRowIndex, i];
        array[lastRowIndex, i] = temp;
    }
    return array;
}



int[,] myArray = GetArray(5, 6, 1, 9);
PrintArray(myArray);
Console.WriteLine();
Swap1andLastRow(myArray);
PrintArray(myArray);