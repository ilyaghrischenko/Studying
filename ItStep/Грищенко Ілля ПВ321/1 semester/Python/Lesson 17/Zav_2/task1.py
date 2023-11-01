try:
    x = int(input("Введіть число: "))
    if x < 0:
        raise Exception
except Exception:
    print("Ви ввели від'ємне число")
    exit()
    
print(x**0.5)