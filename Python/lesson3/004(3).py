# считайте строковые данные из файла. 
# создайте словарь содержащий все символы 
# в файле




def CreatDictionary():
    data = open('text3.txt', encoding='utf-8')
    string1 = data.read()
    data.close
    new_dictionary = {}
    print(string1)
    for i in string1:
        new_dictionary[i] = i
    print(new_dictionary)


CreatDictionary()