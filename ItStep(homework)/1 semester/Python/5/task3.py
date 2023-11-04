x = int(input("Введіть кількість метрів: "))

y = int(input("1 - в милі\n2 - в дюйми\n3 - в ярди\n"))

mil = x / 1609
d = x * 39.37
u = x * 1.094

if y == 1:
    print(f"{x} метрів = {mil} миль")
elif y == 2:
    print(f"{x} метрів = {d} дюймів")
elif y == 3:
    print(f"{x} метрів = {u} ярдів")