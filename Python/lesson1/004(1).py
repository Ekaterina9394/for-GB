# напишите программу на вход принимает число N и выводит
# числа от -N до N
# 3 - -1 -2 -3 0 1 2 3 

from math import floor


N = input("Введите число: ")
N = int(N)

numbers = range (-N, N+1)
print(*numbers)
