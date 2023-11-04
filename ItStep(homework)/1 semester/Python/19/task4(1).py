#1
k = int(input("Введіть кількість елементів: "))
x = [int(input(f"Введіть {i+1} елемент: ")) for i in range(k)]

def mas(x):
    s = 0
    for i in x:
        if i < 0:
            raise Exception
        else:
            s += i
    print("Сума всіх елементів списку -", s)
    
try:
    mas(x)
except Exception:
    print("Список має від'ємний елемент!")