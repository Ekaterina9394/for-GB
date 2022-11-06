# при работе с документацией менеджер допустил 
# шибку названия товаров перемешались с ценами. 
# помогите восстановить документ. порядковый 
# номер товара совпадает с номером цены
# туфли рубашка 2000 1000 шарф юбка шорты 1500 3000 
# сапоги 500 5000 брюки 1500 2000 свитер


def Work():
    text3 = open('text3.txt', encoding='utf-8')
    string = text3.readline()
    text3.close()
    clothes = []
    prices = []
    string = string.split()
    for i in string:
        if i.isdigit():
            prices.append(i)
        else:
            clothes.append(i)
    for i in range(len(prices)):
        prices[i]
        print(clothes[i] + " " + prices[i])
        
Work()