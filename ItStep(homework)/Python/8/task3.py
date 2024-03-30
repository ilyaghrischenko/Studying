x = int(input("Введіть початок діапазону: "))
y = int(input("Введіть кінець діапазону: "))

if x > y:
    x, y = y, x
    print("Числа введені в не вірному порядку, тому вони були замінені")

for i in range (x, y + 1):
    if i % 3 == 0 and i % 5 == 0:
        print("Fizz Buzz")
    elif i % 3 != 0 and i % 5 != 0:
        print(i)
    elif i % 3 == 0:
        print("Fizz")
    elif i % 5 == 0:
        print("Buz")