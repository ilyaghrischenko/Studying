x = {}

for i in range(2):
    y = input(f"Введіть {i} ключ: ")
    x[y] = input(f"Введіть значення для {i} ключа: ")
    
def zam(x):
    try:
        h = input("Введіть ключ: ")
        print(f"Значення - {x[h]}")
        x[h] = print("Введіть оновлене значення: ")
    except KeyError:
        print("Такого ключа не існує")
        
def vid(x):
    print(x)
    
def poshyk(x):
    try:
        h = input("Введіть ключ: ")
        print(f"Значення - {x[h]}")
    except KeyError:
        print("Такого ключа не існує")
        
def ydal(x):
    h = input("Введіть ключ: ")
    del x[h]
    
while True:
    print("Оберіть дію (1 - Відображененя словника)\n(2 - Пошук значення в словнику)\n(3 - Заміна значення в словнику. Значення має бути знайдено ключем)\n(4 - Відображення значення за ключем, введеним користувачем)\n(5 - Видалення значення за ключем, введеним користувачем)")
    t = int(input("Оберіть дію(0 для виходу): "))
    if t == 0:
        break
    elif t == 1:
        vid(x)
    elif t == 2:
        poshyk(x)
    elif t == 3:
        zam(x)
    elif t == 4:
        poshyk(x)
    elif t == 5:
        ydal(x)