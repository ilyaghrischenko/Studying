import random

ocinka = 0
lvl = int(input("Введіть рівень складності\n1 - (1-4), 2 - (1-7), 3 - (1-10): "))
i = 0

while i < 12:
    if lvl == 1:
        x = random.randint(1, 4)
        y = random.randint(1, 4)
    elif lvl == 2:
        x = random.randint(1, 7)
        y = random.randint(1, 7)
    elif lvl == 3:
        x = random.randint(1, 10)
        y = random.randint(1, 10)
    b = int(input(f"{x} * {y} = "))
    if x * y == b:
        print("Правильна відповідь!")
        ocinka += 1
    else:
        print("Не правильна відповідь!")
    i += 1
print(f"Кількість правильних відповідей: {ocinka}")