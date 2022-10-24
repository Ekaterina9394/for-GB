# дано число N. найти все его делители. Для каждого
# делителя укажите четный он или нечетный
# 10 -> четный, 5 нечетный, 2 четный, 1 нечетный

def CheckEven(x):
    if x % 2 == 0:
        return " - четный"
    else:
        return " - нечетный"


def task0(a):
    for i in range(1, a+1):
        if a % i == 0:
            print(i, end = " ")
            print(CheckEven(i))

number = input("Введите число: ")
number = int(number)
task0(number)