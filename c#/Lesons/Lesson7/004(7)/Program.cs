// задайте двумерный массив. найдите сумму
//элементов находящихся на главной диагонали
//индексами (0,0); (1,1) и тд
// 1 4 7 2
// 5 9 2 3 -> 1+9+2=12
// 8 4 2 4 

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
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
       }
}

void SumNumberMainDiag (int[,] collection)
{
    int diagPos = 0;
    int sum = 0;
    for (diagPos = 0; diagPos < collection.GetLength(0); diagPos++)
        {
            sum = sum + collection[diagPos, diagPos];
        }
        Console.WriteLine($"Сумма  элементов на главной диагонали равна {sum}");
}

Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());


int[,] myArray = GetArray(m, n);
PrintArray(myArray);


SumNumberMainDiag(myArray);