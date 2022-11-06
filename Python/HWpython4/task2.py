# В первой строке файла находится информация об ассортименте мороженного, во второй - информация о том, какое мороженное есть на складе. Выведите названия того товара, который закончился.
#1. «Сливочное», «Бурёнка», «Вафелька», «Сладкоежка»
#2. «Сливочное», «Вафелька», «Сладкоежка»
#Закончилось: «Бурёнка»


data = open("task2.txt", encoding="utf-8")
ice = data.readlines()
data.close

string1 = set(ice[0].replace("\n", "").split(", "))
string2 = set(ice[1].replace("\n", "").split(", "))
print(string1)
print(string2)
print(string1.difference(string2))