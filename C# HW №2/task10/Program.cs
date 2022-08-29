//Принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа. 456 -> 5


Console.Write("Введите трёхзначное число: ");
int x = int.Parse(Console.ReadLine());

int a1 = x / 10;
int a2 = a1 % 10;


System.Console.WriteLine($"{x} -> {a2}"); 