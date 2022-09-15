// Напишите функцию и запустите её, которая принимает
//на вход число и выдает сумму цифр в числе
// 82 - 10, 9012 - 12, 452 - 11

int SumNums(int number)
{
    int lenNum = Convert.ToString(number).Length;
    int advance = 0;
    int sum = 0;
    for (int i = 0; i < lenNum; i++)
    {
        advance = number - number % 10;
        sum = sum + (number - advance);
        number = number / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{SumNums(num)}");
