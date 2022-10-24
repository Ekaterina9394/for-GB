#Даны две строки. Посчитайте сколько раз каждый символ
#первой строки встречается во второй
#«one» «onetwonine» - o – 2, n – 3, e – 2

string_1 = input("Введите слово: ")
string_2 = input("Введите слово для поиска букв: ") 

for el in string_1:
    num = string_2.count(el)
    print(f'{el} - {num}')