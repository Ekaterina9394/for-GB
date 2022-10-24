#Напишите программу, которая принимает на вход число N и выдает список факториалов для чисел от 1 до N.
#N = 4 -> [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)

from math import factorial


n = input("Введите число: ")
n = int(n)

factorial = 1
 
for i in range(1, n+1):
        factorial *= i
        print(factorial)
 



