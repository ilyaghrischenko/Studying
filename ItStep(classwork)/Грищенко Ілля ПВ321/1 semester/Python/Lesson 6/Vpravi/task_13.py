a = int(input("Введіть а(цеглина): "))
b = int(input("Введіть b(цеглина): "))
c = int(input("Введіть с(цеглина): "))
x = int(input("Введіть x(отвір): "))
y = int(input("Введіть y(отвір): "))

if a < x and b < x or c < x and a < y or b < x and c < y:
    print("Цеглина пролізе у отвір")
else:
    print("Ні, цеглина не пролізе")