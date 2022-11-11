# Задача 3. Задайте список случайных чисел от 1 до 10. Посчитайте, сколько всего совпадающих элементов есть в списке. Удалите все повторяющиеся элементы.


import random

def RandNum():
    size = 10
    numbers = [random.randint(1, 10) for i in range(size)]
    coinNum = set(numbers)
    numbers.sort()
    print(numbers)
    count = list(filter(lambda x: x > 1, [numbers.count(i) for i in coinNum]))
    print(f"кол-во повторяющихся чисел {sum(count)}")
    print(f"список уникальных чисел {coinNum}")

RandNum()