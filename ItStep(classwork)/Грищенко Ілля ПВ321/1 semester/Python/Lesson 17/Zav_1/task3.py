x = input("Введіть значення масиву: ").split()
y = ''

for i in range(len(x)):
    try:
        if x[i].isdigit() == False:
            raise ValueError
    except ValueError:
        print("Неможливо перетворити")
        exit()
    y += x[i]
    
print(y)