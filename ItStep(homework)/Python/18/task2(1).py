def fac(x):
    try:
        if x < 0:
            raise Exception
        else:
            fact = 1
            for i in range(1, x + 1):
                fact *= i
            return fact
    except Exception:
        print("Ви ввели від'ємне число")

try:
    x = int(input("Введіть число, щоб знайти факторіал: "))
    result = fac(x)
    if result is not None:
        print(result)
except ValueError:
    print("Введено некоректне число")