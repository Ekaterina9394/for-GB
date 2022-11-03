# Задача 2. В файле находятся названия фруктов. Выведите все фрукты, названия которых начинаются на заданную букву.
#а –> абрикос, авокадо, апельсин, айва.


def Fruts():
    texttask2 = open('texttask2.txt', encoding='utf-8')
    string = texttask2.readline()
    texttask2.close()
    new_lst = []
    letter = input('Введите букву: ').lower()
    print()
    for word in string.split():
        if word.lower().startswith(letter):
            if not word[-1].isalpha():
                word = word[:-1]
            new_lst.append(word)
    print(', '.join(new_lst))
 
Fruts()