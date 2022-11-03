# дан файл заполненный числами построчно
# считайте файл. Выведите все элементы 
# стоящие на четных строках а потом на нечетных

def Numbers():
    num = open('text2.txt', encoding='utf-8')
    point = num.readlines()
    num.close()
    for i in range(0,len(point),2):
            print(point[i],end="")
    for i in range(1,len(point),2):
            print(point[i],end="")


Numbers()
