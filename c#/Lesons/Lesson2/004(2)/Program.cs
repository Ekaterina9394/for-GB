﻿//принимает на вход число и проверяет кратно ли оно 
//одновременно 7 и 23

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 7 == 0 && num % 23 ==0) //&& - проверяет условие слева,
                                  //если 1е условие не выполняется,
                                  //то дальше проверка не идёт - нет смысла
                                  //& - проверяет оба условия (увеличивается время работы)
                                  // || - логическое "или"
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}