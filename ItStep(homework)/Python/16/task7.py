def palindrom(x):
    if len(x) % 2 != 0:
        return False
    else:
        if x[::-1] == x:
            return True

x = input("Введіть число: ")

print(palindrom(x))