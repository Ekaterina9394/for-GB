def Bot():
    name = input()
    if name == "привет, как тебя зовут?":
        print(f'Привет,  я робот Анатолий!')
    elif name == "что делаешь?":
        print(f'Важную работу =)')
    else:
        print(f'Извините, я Вас не понимаю')

Bot()