// программа котораяя перевернет одномерный массив
//последний элемент будет на первом месте а первый на последним
//(12345) - (54321)

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i ++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int[] myArray = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", myArray));
ReverseArray(myArray);
Console.WriteLine(String.Join(" ", myArray));