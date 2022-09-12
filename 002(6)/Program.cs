// принимает на вход 3 числа и проверяеть может ли 
//существовать треугольник со сторонами такой длины.
//теорема о неравенстве треугольника: каждая сторона
//треугольника меньше суммы 2х других сторон

bool Triangle(int a, int b, int c)
{
    return (a < b+c && b < a + c && c < a + b);
}

Console.WriteLine("Введите число a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Triangle(num1, num2, num3);
if (Triangle(num1, num2, num3)) Console.WriteLine("Может существоват");
else Console.WriteLine("Не может существовать");