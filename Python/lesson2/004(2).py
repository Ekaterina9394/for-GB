# дано число N. Заполните список длиной N элементами
# 1, -3. 9, -27, 81, -243 ...
# N = 5 -> [1, -3. 9, -27, 81]

N = int(input())
list = []

for i in range(0, N):
    list.append((-3)**i)
print(list)