

def ReadLastRow():
    data = open('text.txt')
    print(data)
    text = data.readlines()
    print(text[- 1])
    data.close()