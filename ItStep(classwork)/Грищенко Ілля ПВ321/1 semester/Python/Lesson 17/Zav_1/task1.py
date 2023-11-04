try:
    x = int(input("Введіть 1 число: "))
    y = int(input("Введіть 2 число: "))
    
    if y == 0:
        print("Ділити на 0 неможливо")
    else:
        d = x / y
        print(f"{x} / {y} = {d}")
except ValueError:
    print("Будь ласка, введіть коректне ціле число")
