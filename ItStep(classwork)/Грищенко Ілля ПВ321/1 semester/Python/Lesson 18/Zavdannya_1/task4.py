x = open("data/task4(1).txt", encoding='utf-8')
file_x = x.readlines()

zir = "************\n"

index = len(file_x)
for i in file_x[::-1]:
    if ',' not in i:
        index = file_x.index(i)
        break
    
file_x.insert(index + 1, zir)
x.close()
print(file_x)
y = open("data/task4(2).txt", "w")
y.writelines(file_x)
y.close()
