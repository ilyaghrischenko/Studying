x = open("data/task3(1).txt", encoding='utf-8')
file_x = x.readlines()
file_x.reverse()
print(file_x)

y = open("data/task3(2).txt", "w")
y.writelines(file_x)
y.close()

y = open("data/task3(2).txt", encoding='utf-8')
print(y.read())