while True:
    i = 1
    x = int(input(f"Введіть {i} число(0 для виходу): "))
    i += 1
    y = int(input(f"Введіть {i} число(0 для виходу): "))

    if x == 0 or y == 0:
        break

    print(f"{x} у {y} степені = {x ** y}")