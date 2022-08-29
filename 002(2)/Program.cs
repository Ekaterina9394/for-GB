//выводит случайное трехзначное число и удаляет вторую цифру этого числа

int x = new Random().Next(100, 1000);

int a1 = x / 100;
int a2 = x % 10;

int res = a1 * 10 + a2;

System.Console.WriteLine($"{x} -> {res}"); 
