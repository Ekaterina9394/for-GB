//принимает на вход число N и выдает таблицу квадратов
// чисел от 1 до N пример 5 -> 1,4,9,16,25

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int count = 1;
while (count <= N)
{
    Console.Write($"{count*count}, ");
    count++;
}
Console.WriteLine();

//2й вариант
for (int x = 1; x <= N; x++)
{
    Console.Write($"{x*x}, ");
}
Console.WriteLine();