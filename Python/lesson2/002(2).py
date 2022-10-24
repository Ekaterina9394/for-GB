#Выведите таблицу истинности для выражения -,XvY.
# X  Y  -,XvY
# 0  0    1
# 0  1    1
# 1  0    0
# 1  1    1


#x = [0, 1]
#y = [0, 1]
print("x | y | -,XvY")
for x in range(0, 2):
    for y in range(0, 2):
        xvy = not x or y
        print(f"{x} | {y} | {int(xvy)}")