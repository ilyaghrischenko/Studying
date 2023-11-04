l = 109
v = int(input("Введіть швидкість: "))
t = int(input("Введіть годину: "))

pozn = (v * t) % l 

print("Вася зупинився на позначці", int(pozn))