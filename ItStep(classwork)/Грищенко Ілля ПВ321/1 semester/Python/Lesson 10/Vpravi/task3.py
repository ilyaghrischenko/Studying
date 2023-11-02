x = int(input("Введіть початок: "))
y = int(input("Введіть кінець: "))

while True:
    a = int(input("Введіть число: "))
    if x <= a <= y:
        for i in range(x, y + 1):
            if i != a:
                print(i, end=' ')
            else:
                print(f"!{a}!", end=' ')
        break
    elif a < x or a > y:
        continue
