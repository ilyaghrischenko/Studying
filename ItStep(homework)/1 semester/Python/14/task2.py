import random

x = []
k_v = 0
k_0 = 0
k_d = 0

for i in range(15):
    x.append(random.randint(-100, 100))
    if x[i] < 0:
        k_v += 1
    if x[i] == 0:
        k_0 += 1
    if x[i] > 0:
        k_d += 1

print(f"{x}\nКількість від'ємних чисел: {k_v}\nКількість додатніх чисел: {k_d}\nКількість нулів: {k_0}\nМаксимальне число: {max(x)}\nМінімальне число: {min(x)}")