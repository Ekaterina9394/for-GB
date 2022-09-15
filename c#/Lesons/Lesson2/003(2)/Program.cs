// принимает 2 числа и выводит, 
//является ли второе число кратным 
//первому. Если число 2 не кратно 
//числу 1, то программа выводит 
//остаток от деления

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int c = a % b;
if (c == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток = {c}");
}