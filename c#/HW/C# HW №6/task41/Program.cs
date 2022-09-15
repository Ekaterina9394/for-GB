// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3



int[] StrToArr(string str)
{
    int[] numArray = Array.ConvertAll(str.Split(), int.Parse);
    return numArray;
}

int NumCnt(int[] myArray)
{
    int count = 0;
    
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.Write("Введите числа (вводите через пробел): ");
string num = Console.ReadLine();
int result = NumCnt(StrToArr(num));
Console.WriteLine($"Количество чисел больше нуля: {result}");
