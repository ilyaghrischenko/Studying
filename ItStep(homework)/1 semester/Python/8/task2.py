x = int(input("Введіть початок діапазону: "))
y = int(input("Введіть кінець діапазону: "))

if x > y:
    x, y = y, x
    print("Числа введені в не вірному порядку, тому вони були замінені")

print("\nВсі числа в діапазоні")
for i in range (x, y + 1):
    print(i)

print("\nВсі числа діапазону в спадному порядку")
for i in range (y, x - 1, -1):
    print(i)

print("\nВсі числа, кратні 7")
for i in range (x, y + 1):
    if i % 7 == 0:
        print(i)

print("\nКількість чисел, кратних 5")
k = 0
for i in range (x, y + 1):
    if i % 5 == 0:
        k += 1
print(k)