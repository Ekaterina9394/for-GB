# в зоопарк отправили отчет о новом поступлении 
# зверей с ошибкой в результате которой некоторые
#  данные не расшифровались. расшифруйте данные. 
# определите в какой клетке находится лев. номер 
# клетки совпадает с номером строки


def convertToBinary(number):
    result = ""
    while number > 0:
        result = str(number % 2) + result
        number = number // 2
    return result


alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"

codeList = [convertToBinary(i) for i in range(len(alphabet))]
codeList = ["0" * (6 - len(i)) + i for i in codeList]


dictionary = {}
for i in range(len(codeList)):
    dictionary[codeList[i]] = alphabet[i]
print(dictionary)

data = open("animals.txt", "r")
animalCodeList = data.readlines()
data.close()

for animal in animalCodeList:
    for i in range(len(animal)//6):
        bias = i * 6
        print(dictionary[animal[bias:bias + 6]], end = "")
    print()