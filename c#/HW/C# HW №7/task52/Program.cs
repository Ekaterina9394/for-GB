﻿// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    
    for (int i = 0; i < m; i++)
       {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
       }
}

void AvgCol(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avg = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avg = (avg + array[i, j]);
        }
        avg = avg / array.GetLength(1);
        Console.Write(avg + "; ");
    }
}

Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());


int[,] myArray = GetArray(m, n);
PrintArray(myArray);

AvgCol(myArray);
