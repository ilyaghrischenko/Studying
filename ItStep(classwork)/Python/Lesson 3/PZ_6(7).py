a = int(input("Введіть кількість олівців: "))
b = int(input("Введіть кількість ручок: "))
c = int(input("Введіть кількість фломастерів: "))

cost_a = float(input("Введіть вартість олівця: "))
cost_b = 2 + cost_a
cost_c = cost_b + 7

total = cost_a + cost_b + cost_c
print(total)