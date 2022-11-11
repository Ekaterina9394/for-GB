#  с помощью анонимной функции найдит в списке 15 элементов числа кратные 5. 
# заполните список случайным образом числами от 1 до100


import random

numbers = [random.randint(1, 100) for i in range(15)]
print(numbers)


#for i in number:
#    if i % 5 == 0:
#        print(i)

result = lambda x: x % 5 == 0
result = list(filter(result, numbers))
print("получаем", result)