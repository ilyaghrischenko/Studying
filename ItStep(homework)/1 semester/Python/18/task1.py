try:
    fact = 1
    x = int(input("Введіть число щоб знайти факторіал: "))
    if x < 0:
        raise Exception
    else:
        for i in range(1, x + 1):
            fact *= i
        print(fact)
except Exception:
    print("Ви ввели від'ємне число")