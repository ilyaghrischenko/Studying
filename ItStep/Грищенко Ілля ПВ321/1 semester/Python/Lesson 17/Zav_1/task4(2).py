# 2
x = input("Введіть значення масиву: ").split()

def mas(x):
    y = ''
    for i in range(len(x)):
        y += x[i]
    return y

for i in range(len(x)):
    try:
        if x[i].isdigit() == False:
            raise ValueError
    except ValueError:
        print("Неможливо перетворити")
        exit()
        
print(mas(x))