//напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли 
//этот день выходным. 6 -> да 7 -> да 1 -> нет

Console.Write("Введите номер дня недели: ");
int x = int.Parse(Console.ReadLine());

if (0 < x  & x < 8)
{
    if (0 < x  & x < 6) Console.WriteLine($"{x} -> нет");
    else Console.WriteLine($"{x} -> да");
}
else Console.WriteLine($"{x} - не является днём недели");