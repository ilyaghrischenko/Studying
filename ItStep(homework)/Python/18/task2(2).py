#2
def fac():
    try:
        x = int(input("Введіть число, щоб знайти факторіал: "))
        if x < 0:
            raise Exception
    except ValueError:
        print("Введено некоректне число")
        exit()
    except Exception:
        print("Ви ввели від'ємне число")
        exit()
    fact = 1
    for i in range(1, x + 1):
        fact *= i
    print(fact)

fac()