Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
double sqr_b = Math.Pow(b, 2);
if (a == sqr_b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}