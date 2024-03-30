x = int(input("Введіть кількість годин: "))

if 0 <= x < 6:
    print("Good Night")
elif 6 <= x < 13:
    print("Good Morning")
elif 13 <= x < 17:
    print("Good Day")
elif 17 <= x < 24:
    print("Good Evening")