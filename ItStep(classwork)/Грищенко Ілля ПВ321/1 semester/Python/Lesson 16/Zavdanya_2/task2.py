a = int(input("Введіть перше число: "))
b = int(input("Введіть друге число: "))
def s(a, b):
    if a > b: return 0
    suma = a + s(a + 1, b)
    return suma
print(s(a, b))