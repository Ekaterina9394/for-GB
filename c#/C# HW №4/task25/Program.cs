// Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.

int Exponentiation(int A, int B)
{
    int result = 1;
    for(int i=1; i<=B; i++)
    {
        result = result * A;
    }
    return result;
}
Console.Write("Введите число возводимое в степень: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень числа: ");
int B = int.Parse(Console.ReadLine());

int exponentiation = Exponentiation(A, B);
Console.WriteLine("Ответ: " + exponentiation);

