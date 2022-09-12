// принимает на вход координаты точки х и у 
//причем х и у не равны 0 и выдает
//номер четверти плоскости в котором 
//находится эта точка
//        |y
//     2  |  1
//   _____|_____x
//        |
//     3  |  4
// чтобы получить 3 нужно чтобы х и у были
// отриц. чтобы получить 2 то х (-) у(+) и тд

Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write("1");
}
else
if (x < 0 && y > 0)
{
    Console.Write("2");
}
if (x < 0 && y < 0)
{
    Console.Write("3");
}
else
if (x > 0 && y < 0)
{
    Console.Write("4");
}