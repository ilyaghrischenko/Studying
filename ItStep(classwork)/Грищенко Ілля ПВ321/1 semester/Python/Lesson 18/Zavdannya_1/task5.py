x = open("data/task5(1).txt", encoding='utf-8')
file_x = x.readlines()
x.close()

k = 0
b = input("Введіть літеру: ")
for i in file_x:
    if b.capitalize() == i[0].capitalize():
        print(i)
        k += 1
        
print(f"Кількість слів, які починаються з символу {b} - {k}")