s_day = int(input("Пробіг за день: "))
p = int(input("Введіть відсоток: "))
s = int(input("Введіть сумарний пробіг: "))

p /= 100
k = 0
goal = 0

while goal <= s:
    s_day = s_day + s_day * p
    goal += s_day
    k += 1
print(f"На {k} день пробіг складе більше - {s}км")