// задайте двумерный массив и найдите элементы
// у которых оба индекса будут четные и замените
//эти элементы на их квадраты
// 1 4 7 2     1 4 49 2
// 5 9 2 3  -> 5 9 2 3
// 8 4 2 4     64 4 4 4


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    
    for (int i = 0; i < m; i++)
       {

        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 5);
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

void SquareNumberEvenIn (int[,] collection)
{
    for (int rows = 0; rows < collection.GetLength(0); rows+=2)
       {
        for (int cols = 0; cols < collection.GetLength(1); cols+=2)
            {
                {
                     collection[rows, cols] *= collection[rows, cols];
                }
            }
       }
}

Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());


int[,] myArray = GetArray(m, n);
PrintArray(myArray);
SquareNumberEvenIn(myArray);
PrintArray(myArray);