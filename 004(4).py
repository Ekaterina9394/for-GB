# сгенерируйте список случайных чисел от 1 до 10 состоящих из 10 элементов
# удалите из списка дубликаты уже имеющихся элементов


import random

def GetNumbers():
    data = open("list.txt", "w")
    numbers = [random.randint(10, 20) for i in range(0, 10)]
    data.write(str(numbers))
    print(numbers)
    data.close()

GetNumbers()

def FideDublicate():
    data = open("list.txt", "r", encoding="utf=8")
    num = data.readline()[1: -1].split(", ")
    num = [int(i) for i in num]
    num = set(num)
    print(num)

FideDublicate()
