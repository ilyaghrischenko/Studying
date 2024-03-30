while True:
    x = int(input('Введіть діапазон(>1)\nДля виходу введіть "0": '))
    if x == 0:
        print("\nЗавершення.")
        break
    elif x > 1:
        for i in range(2, x + 1):
            k = 0
            for j in range(2, i + 1):
                if i % j == 0:
                    k += 1
            if k == 1:
                print(i, end=' ')
        print()
    else:
        print("\nВведено не вірний діапазон.\nПовинно бути >1\n")
        continue