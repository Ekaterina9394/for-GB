// Программа, которая задаёт массив из N элементов, 
//заполненных
// случайными числами из a, b  и выводит их на экран
// 5,0,20 - (1 2 5 7 19) 

int [] InitArray(int arr_cnt, int arr_min, int arr_max)
{
int[] arr = new int[arr_cnt];
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(arr_min, arr_max);
    }
    return arr;
}

Console.Write("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу: ");
int b = int.Parse(Console.ReadLine())-1;

Console.WriteLine(String.Join(" ", InitArray(n, a, b)));
