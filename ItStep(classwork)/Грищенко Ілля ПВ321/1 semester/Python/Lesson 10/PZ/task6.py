x = int(input("Введіть кількість блоків: "))

h = 0
blocks = x
i = 1

while True:
    if i <= blocks:
        blocks -= i
        h += 1
    else:
        print(f"Висота піраміди: {h}")
        break
    i += 1