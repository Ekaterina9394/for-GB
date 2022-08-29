//принимает на вход 2 числа и проверяет является ли
//одно число квадратом другого пример 5 25 -> да

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}