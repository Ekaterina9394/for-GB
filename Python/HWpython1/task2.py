# Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
# A (3,6); B (2,1) -> 5,1
# A (7,-5); B (1,-1) -> 7,21

import math

x1 = input("Введите x1: ")
x1 = int(x1)
y1 = input("Введите y1: ")
y1 = int(y1)
x2 = input("Введите x2: ")
x2 = int(x2)
y2 = input("Введите y2: ")
y2 = int(y2)

s1 = (x1 - x2) * (x1 - x2)
s2 = (y1 - y2) * (y1 - y2)
sum = s1 + s2

result = math.sqrt(sum)
result = float(result)
print(result)



