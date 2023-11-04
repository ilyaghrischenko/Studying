n = int(input("Введіть число зірок: "))
def star(n):
    if n > 0:
        print("*", end='')
        star(n-1)

star(n)