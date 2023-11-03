def dob(x, y):
    d = 1
    for i in range(x, y + 1):
        d *= i
    return d

x = int(input("Введіть початок діапазону: "))
y = int(input("Введіть кінець діапазону: "))

if x > y:
    x, y = y, x

print(f"Діапазон - [{x}:{y}]\nДобуток:", dob(x, y))