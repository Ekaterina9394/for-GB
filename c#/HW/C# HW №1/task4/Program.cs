//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
if (a > b)
{
    if (a > c) Console.WriteLine(a);
    else Console.WriteLine(c);
}
else
{
    if (b > c) Console.WriteLine(b);
    else Console.WriteLine(c);
}