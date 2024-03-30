import random

x = []
y = int(input("Введіть кількість елементів у списку: "))

for i in range(y):
    x.append(random.randint(-10, 10))
    
print(f"{x} - Список\n")

#1
y = [i for i in x if i % 2 == 0 and i != 0]
print(f"{y} - список цілих, що містить тільки парні числа")

#2
y = [i for i in x if i % 2 != 0]
print(f"{y} - список цілих, що містить тільки непарні числа")

#3
y = [i for i in x if i < 0]
print(f"{y} - список цілих, що містить тільки від'ємні числа")

#4
y = [i for i in x if i > 0]
print(f"{y} - список цілих, що містить тільки додатні числа")
