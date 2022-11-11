# Задача 2. Дан список случайных чисел. Создайте список, в который попадают числа, описывающие возрастающую последовательность. Порядок элементов менять нельзя.
#[1, 5, 2, 3, 4, 6, 1, 7] =>[1, 2, 3] или [1, 7] или [1, 6, 7] и т.д.


import random

def increasing():
    size = 10
    numbers = [random.randint(1, 100) for i in range(size)]
    print(numbers)
    index = random.randint(0, size - 1)
    result = [numbers[index]]
    
    while index < size:
        index = random.randint(index + 1, size)
        if index < size:
            if numbers[index] > result[-1]:
                result.append(numbers[index])
        
    print(result)

increasing()