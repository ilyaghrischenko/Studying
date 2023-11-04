x = int(input("Введіть 3значне число: "))
roz1 = x // 100
roz2 = x // 10 - roz1 * 10
roz3 = x % 100 - roz2 * 10
sum = roz1 + roz2 + roz3
print(f"Перший розряд {roz1}")
print(f"Другий розряд {roz2}")
print(f"Третій розряд {roz3}")
print(f"Сума чисел {sum}")