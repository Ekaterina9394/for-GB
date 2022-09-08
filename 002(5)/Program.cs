// замена элементов массива: положительные заменить 
//на отриц и наоборот
//(-4, -8) - > (4, 8)

//генерируем массив
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
//------------ само решение
void ChangeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}
int[] myArray = GetArray(10, -100, 100);
Console.WriteLine(String.Join(" ", myArray));
ChangeArray(myArray);
Console.WriteLine(String.Join(" ", myArray));