// выводит массив из 8 элементов заполненный нулями и
//единицами в случайном порядке

int [] InitArray()
{
    int[] arr = new int[8];
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(2);
    }
    return arr;
}


void ReadArray(int [] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

ReadArray(InitArray());

//2й вариант
Console.WriteLine(String.Join(", ", InitArray()));