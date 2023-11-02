gb = int(input("Введіть розмір(гб): "))
sp = int(input("Введіть швидкість: "))

n = int(input("1 - год хв сек\n2 - хв сек\n3 - сек: \n"))

bytes = gb * 8e-9

if n == 1:
    sec = bytes / sp
    hours = sec // 3600
    mn =  bytes % 3600 // 60
    sec = bytes % 60
    print(f"Файл завантажиться через {hours} год {mn} хв {sec} сек")
elif n == 2:
    mn =  bytes % 3600 // 60
    sec = bytes % 60
    print(f"Файл завантажиться через {mn} хв {sec} сек")
elif n == 3:
    sec = bytes / sp
    print(f"Файл завантажиться через {sec} сек")