# актеров разделили на списки по 3м качествам 
# (умный красивые и сильные). на главную рольну жен актер 
# обладающий всеми тремя качествами. определите сколько есть 
# претедентов на главную роль. списки актеров поместите 
# в соответствующие файлы
# крсивые: Илья Федор Семен Олег Лев Антон Боря Стас Марк Ян
# умные : Илья Георгий Лев Демьян Антов Владислав Боря Стас Марк Влад
# сильные: Федор Горгий Олег Демьян Артем Елисей Боря Стас Влад


def openFile(nameFile):
    f = open(nameFile, encoding="utf-8")
    phrase = f.readlines()
    f.close
    list = phrase[0].split()
    return set(list)

handsome = openFile("handsome.txt")
smart = openFile("smart.txt")
strong = openFile("strong.txt")




print(handsome.intersection(smart).intersection(strong))