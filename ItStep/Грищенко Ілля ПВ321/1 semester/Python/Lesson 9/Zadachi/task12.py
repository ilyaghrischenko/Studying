x = int(input("Введіть 1 доданок: "))
k = 0
score = 0

while score < 100:
    score += x
    x += 3
    k += 1
print(f"Мінімальна кількість доданків - {k}")