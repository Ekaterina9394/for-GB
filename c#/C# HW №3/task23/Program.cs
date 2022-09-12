//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int count = 1;
while (count <= N)
{
    Console.Write($"{count*count*count}, ");
    count++;
}
Console.WriteLine();

//2й вариант
for (int x = 1; x <= N; x++)
{
    Console.Write($"{x*x*x}, ");
}
Console.WriteLine();