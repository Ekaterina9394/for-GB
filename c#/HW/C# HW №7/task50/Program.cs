// на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же
// указание что такого элемента нет
// 1 4 7 2
// 5 9 2 3 
// 8 4 2 4 
// 17 - такого элемента нет
// 2 - 02 (в первой строчке)

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

void ReturnNum(int[,] array, int x)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if (x == array[i, j])
            { 
                Console.WriteLine($"{i}, {j}");
                count++;
            }   
        }
    }
    if (count == 0) Console.WriteLine($"{x} -> данного элемента нет в массиве");
}


Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите элемент: ");
int num = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n);
PrintArray(myArray);
Console.WriteLine("--------");
ReturnNum(myArray,num);
