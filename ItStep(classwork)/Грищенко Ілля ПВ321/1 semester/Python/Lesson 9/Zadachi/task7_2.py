x = int(input("Введіть 1 число: "))
y = int(input("Введіть 2 число: "))

i = 1

if x > y:
    p = x
elif y > x:
    p = y
    
while i <= p:
    if x % i == 0 and y % i == 0:
        nsd = i
    i += 1
print(int((x * y) / nsd))