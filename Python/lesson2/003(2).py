# программа в которой пользователь задает 2 строки
# а программа определяет количество вхождений одной строки в другую
# qwe qwertyqwe - 2

string_1 = input()
string_2 = input()
count = 0

if len(string_1) > len(string_2):
    #print(string_1)
    for i in range(len(string_1)):
        #print(string_1[i:i+len(string_2)])
        if string_2 == string_1[i:i+len(string_2)]:
            count +=1
    print("Количество совпадений строк:", count)


# другой вариант решения
# print(f"Текст 1 входит в текст 2 {string_1.count(string_2)} раз")