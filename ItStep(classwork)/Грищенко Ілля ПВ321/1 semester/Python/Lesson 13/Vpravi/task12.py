x = input("Введіть 1 рядок: ")
y = input("Введіть 2 рядок: ")

if len(x) == len(y):
    print("Однакові")
elif len(x) > len(y):
    print(x)
elif len(x) < len(y):
    print(y)