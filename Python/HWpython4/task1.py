#Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
#60 -> 2, 2, 3, 5


num = int(input("Введите число: "))
list = []
for i in range(2, num):
    while num % i == 0:
        num /= i
        list.append(i)
print(list)