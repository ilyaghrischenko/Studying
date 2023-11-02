x = open("data/task2(1).txt")
file_x = x.readlines()

y = open("data/task2(2).txt", "w")
y.writelines(file_x)
y.close()

y = open("data/task2(2).txt", encoding='utf-8')
print(y.read())