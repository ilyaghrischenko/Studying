x = [int(input("1 дата: ")) for i in range(3)]
y = [int(input("2 дата: ")) for i in range(3)]

print(f"\nПерша дата - {x[0]}.{x[1]}.{x[2]}")
print(f"Друга дата - {y[0]}.{y[1]}.{y[2]}")

def riz(x, y):
    days = 0
    while x != y:
        if x[1] in [1, 3, 5, 7, 8, 10, 12]:
            if x[0] != 31:
                x[0] += 1
                days += 1
            else:
                x[0] = 1
                if x[1] + 1 != 13:
                    x[1] += 1
                else:
                    x[1] = 1
                    x[2] += 1
        else:
            if x[0] != 30:
                x[0] += 1
                days += 1
            else:
                x[0] = 1
                if x[1] + 1 != 13:
                    x[1] += 1
                else:
                    x[1] = 1
                    x[2] += 1
    return days

print("\nКількість днів:", riz(x, y))