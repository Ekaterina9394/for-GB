// Программа, которая задаёт массив из N элементов, 
//заполненных
// случайными числами из a, b  и выводит их на экран
// 5,0,20 - (1 2 5 7 19) 

Console.Write("Введите количество элементов: ");
int arr_cnt = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу: ");
int arr_min = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу: ");
int arr_max = int.Parse(Console.ReadLine())-1;
int[] arr = new int[arr_cnt];
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(arr_min, arr_max);
    }
Console.WriteLine(String.Join(" ", arr));