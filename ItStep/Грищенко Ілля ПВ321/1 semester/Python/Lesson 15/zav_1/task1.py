import random

k_v = 0
k_p = 0
k_n = 0
i3_d = 1
d = 1
s = 0

x = []
y = int(input("Введіть кількість елементів у списку: "))

for i in range(y):
    x.append(random.randint(-10, 10))
print(f"{x} - Список")

for j in range(len(x)):
    if j % 3 == 0 and j > 0:
        i3_d *= x[j]
    if x[j] < 0:
        k_v += x[j]
    if x[j] % 2 == 0:
        k_p += x[j]
    if x[j] % 2 != 0:
        k_n += x[j]

if x.index(min(x)) < x.index(max(x)):
    for i in range(x.index(min(x)), x.index(max(x))):
        d *= x[i]
elif x.index(min(x)) > x.index(max(x)):
    for i in range(x.index(max(x)), x.index(min(x))):
        d *= x[i]
        
for i in x:
    if i > 0:
        f_i = x.index(i)
        break
for i in range(len(x)-1, 0, -1):
    if x[i] > 0:
        l_i = i
        break
    
for i in range(f_i+1, l_i):
    s += x[i]
        
print(f"сума від'ємних - {k_v}\nсума парних - {k_p}\nсума непарних - {k_n}\nдобуток елементів з індексами кратними 3 - {i3_d}\nдобуток елементів між мінімальним і максимальним елементом - {d}\nсума елементів, що знаходяться між першим та останнім додатними елементами - {s}")