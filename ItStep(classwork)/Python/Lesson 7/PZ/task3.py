x = int(input("Введіть шестизначне число: "))
x1 = x // 100000
x2 = x // 10000 - x1 * 10
x3 = x // 1000 - x1 * 100 - x2 * 10
x4 = x // 100 - x1 * 1000 - x2 * 100 - x3 * 10
x5 = x // 10 - x1 * 10000 - x2 * 1000 - x3 * 100 - x4 * 10
x6 = x % 10

n = int(f"{x6}{x5}{x3}{x4}{x2}{x1}")

print(n)