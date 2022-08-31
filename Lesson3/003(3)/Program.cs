// принимает на вход координаты 2х точек и находит 
//расстояние между ними в 2D пространстве
// A(3,6); B(2,1) -> 5,09
// чтобы найти корень - корень а в программе это Math.sqrt(a) 
//возвращает цифры дробные double 
// чтобы найти расстояние
// корень квадратный ((x1-x2)^2 + (y1-y2)^2
// чтобы после запятой не было большого остатка надо написать
// :f и количество цифр которые будут показываться

Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());

double s1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));


Console.Write($"{s1:f2}");
// 2й вариант
// int s1 = (x1 - x2) * (x1 - x2);
// int s2 = (y1 - y2) * (y1 - y2);
// int sum = s1 + s2;
// double result = Math.Sqrt(sum);