// задайте одномерный массив из 123 случайных чисел
//найдите количество элементов массива значения
//которых лежат в отрезке (10, 99).
//пример для массива из 5, а не 123 элем. В своем 
//решении сделайте для 123
//выводятся именно двезначные числа
//(6, 18, 122, 7, 2) -> 1
//(1,2,3,4,5,6) -> 0
//(10, 11, 12, 13, 13) -> 5

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] ProducttionArray(int[] array)
{
    int size = array.Length / 2;

    if (array.Length % 2 != 0) size++;
    int result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0) result[size - 1] - array[array.Length / 2];
    return result;
}

Console.WriteLine("Введите длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начало диапазона: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец диапазона: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[] newArray = GetArray(arraySize, arrayStart, arrayEnd);

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Массив: {String.Join(" ", newArray)}");
if (FindNumber(newArray, number)) Console.WriteLine("Да");
else Console.WriteLine("Нет");