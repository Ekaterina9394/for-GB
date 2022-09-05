// принимает число и выдает сумму чисел от 1 до А
// 7 -> 28 (1+2+3+4 и тд)

int GetNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите число A: ");
int num = int.Parse(Console.ReadLine());


Console.WriteLine($"{GetNums(num)}");