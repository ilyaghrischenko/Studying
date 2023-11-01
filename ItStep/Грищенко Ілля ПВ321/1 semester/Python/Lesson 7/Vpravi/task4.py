n = int(input("Введіть кількість корів: "))

if n >= 100:
    print("Не вірне значення")
elif 5 <= n % 10 <= 9 or n % 10 == 0 and n == 11:
    print(f"{n} корів")
elif n % 10 == 1 or n == 1:
    print(f"{n} корова")
elif 2 <= n % 10 <= 4:
    print(f"{n} корови")