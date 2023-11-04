with open("data/task6.txt", encoding='utf-8') as x:
    lines = x.readlines()
poisk = input("Введіть шукане слово: ")
zamina = input("Введіть слово на яке потрібно змінити: ")
k_all = []

for i in lines:
    line_x = i.split()
    for j in range(len(line_x)):
        if line_x[j] == poisk:
            line_x[j] = zamina
    k_all.append(' '.join(line_x))

result = '\n'.join(k_all)

with open("data/task6.txt", "w", encoding='utf-8') as y:
    y.write(result)
