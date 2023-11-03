x = int(input("Виберіть фігуру\n(1 - а, 2 - б, 3 - в, 4 - г, 5 - д\n6 - е, 7 - ж, 8 - з, 9 - и, 10 - к): "))
n = int(input("Введіть розмір: "))

if x == 1:
    t = 0
    y = n
    for i in range(n):
        print('  ' * t, '* ' * y, end=' ')
        print()
        t += 1
        y -= 1

elif x == 2:
    t = 1
    for i in range(n):
        print("* " * t)
        t += 1

elif x == 3:
    if n % 2 == 0:
        n += 1
    t = 0
    y = n
    for i in range(n):
        print("  " * t, "* " * y)
        t += 1
        y -= 2

elif x == 4:
    for i in range(1, n + 1):
        if i == 1:
            print(' ' * (n - i), "*")
        else:
            print(' ' * (n - i), "* " * (i - 1) + "*")


elif x == 5:
# Верхня частина
    for i in range(n, 0, -1):
        print(' ' * (n - i) + "* " * i)

# Нижня частина
    for i in range(2, n + 1):
        print(' ' * (n - i) + "* " * i)


elif x == 6:
    for i in range(1, 2*n):
        for j in range(1, 2*n):
            if i <= n:
                if j <= i or j >= 2*n - i:
                    print("*", end=" ")
                else:
                    print(" ", end=" ")
            else:
                if j <= 2*n - i or j >= i:
                    print("*", end=" ")
                else:
                    print(" ", end=" ")
        print()

elif x == 7:
    x = 1
    y = n-1
    for i in range(n):
        print('* '*x, '  '*y, sep='')
        if i < int(n/2):
            x+=1
            y-=1
        else:
            x-=1
            y+=1

elif x == 8:
    x = 1
    y = n-1
    for i in range(n + 1):
        print('  '*y, '* '*x, sep='')
        if i < int(n/2):
            x+=1
            y-=1
        else:
            x-=1
            y+=1

elif x == 9:
    x = n
    for i in range(n):
        print('* '*x)
        x-=1

elif x == 10:
    x = n-1
    y = 1
    for i in range(n):
        print('  '*x, '* '*y, sep='')
        x-=1
        y+=1