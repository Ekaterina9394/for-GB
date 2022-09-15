// задайте двумерный массив размером m*n, заполенный
//случайними вещественными числами


double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    
    for (int i = 0; i < m; i++)
       {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(0, 10)) + new Random().NextDouble();
        }
       }
       return result;
}


void PrintArray(double[,] array)
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


Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());


double[,] myArray = GetArray(m, n);
PrintArray(myArray);
