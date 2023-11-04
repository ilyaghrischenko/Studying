i = 0

while i != 7:
    x = int(input("Введіть число: "))
    if x == 7:
        i = 7
        print("Good bye!")
    else:
        if x > 0:
            print("Number is positive")
        elif x < 0:
            print("Number is negative")
        elif x == 0:
            print("Number is equal to zero")