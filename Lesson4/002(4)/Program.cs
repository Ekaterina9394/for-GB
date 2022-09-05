// на вход принимает число и выдает количество цифр в числе
// 456 - 3, 78 -2 

int colNumber(int num)
{
    int col = 0;
    while (num!=0)
    {
        col++;
        num = num/10;
    }
    return col;
}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{colNumber(number)}");