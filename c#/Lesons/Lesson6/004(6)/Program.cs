// Не используя рекурсии, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// если N  = 5 -> 01123
// если N = 7 -> 0 1 1 2 3 5 8

int [] Fib(int num)
{
    int[] fArray = new int[num];
    fArray[0] = 0;
    fArray[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fArray[i] = fArray[i - 2] + fArray[i - 1];
    }
    return fArray;
}
Console.WriteLine("Введите число: ");
int fNum = Convert.ToInt32(Console.ReadLine());
if (fNum >=2) Console.WriteLine(String.Join(" ", Fib(fNum)));
else if (fNum == 1) Console.WriteLine("1");
else Console.WriteLine("Нет последовательности");
