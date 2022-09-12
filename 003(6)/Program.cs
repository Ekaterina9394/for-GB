// программа которая будет преобразовывать десятичное
//число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// как получить - делим столбиком на 2 и запоминаем остаток
// 45|_2
// 44|22|_2
// --|22|11|2 и тд результат записываем задои наперед
//  1 --
//     0   

string Binary(int num)
{
    string binaryNum = string.Empty;
    while (num > 0)
    {
        if (num % 2 == 1)
        {
            binaryNum += "1";
        }
        else
        {
            binaryNum += "0";
        }
        num /= 2;
    }
    return binaryNum;
}

string ReverseBinary(string stringNum)
{
    string temp = String.Empty;
    for (int i = stringNum.Length - 1; i >= 0; i --)
    {
        temp += stringNum[i];
    }
    return temp; 
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ReverseBinary(Binary(a)));
