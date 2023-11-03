x = int(input("Введіть число(4 цифри): "))
r1 = x // 1000
r2 = x // 100 - r1 * 10
r3 = x // 10 - r1 * 100 - r2 * 10
r4 = x % 10

dobytok = r1 * r2 * r3 * r4
print(f"{r1} * {r2} * {r3} * {r4} = {dobytok}")