// Напишите программу, которая найдёт точку пересечения двух 
//прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] CrsPnt(int[,] myArray)
{
    int[] crossPoint = new int[2];
    crossPoint[0] = (myArray[1,1] - myArray[0,1]) / (myArray[0,0] - myArray[1,0]);
    crossPoint[1] = crossPoint[0] * myArray[0,0] + myArray[0,1];
    return crossPoint;
}

Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
int[,] myArray = {{k1, b1}, {k2, b2}};
Console.WriteLine(String.Join(" ", CrsPnt(myArray)));

 
 