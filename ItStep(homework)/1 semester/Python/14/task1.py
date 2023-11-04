x = input("Введіть арифметичний вираз: ")

y1 = ""
y2 = ""

for i in range(len(x)):
    if x[i] == "+" or x[i] == "-" or x[i] == "*" or x[i] == "/":
        y1 = int(x[:i])
        y2 = int(x[i+1:])
    if x[i] == "+":
        print(y1 + y2)
    elif x[i] == "-":
        print(y1 - y2)
    elif x[i] == "*":
        print(y1 * y2)
    elif x[i] == "/":
        print(y1 / y2)