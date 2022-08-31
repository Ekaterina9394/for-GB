//Напишите программу, которая принимает на вход координаты 
//трех точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84

Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c1");
int c1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c2");
int c2 = int.Parse(Console.ReadLine());

//1й вариант

double s1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(c1 - c2, 2));

Console.Write($"{s1:f2}");

// 2й вариант
//int b1 = (x1 - x2) * (x1 - x2);
//int b2 = (y1 - y2) * (y1 - y2);
//int b3 = (c1 - c2) * (c1 - c2);
//int sum = b1 + b2 + b3;
//double result = Math.Sqrt(sum);
//Console.Write($"{result:f2}");