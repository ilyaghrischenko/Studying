x = open("data/task1(1).txt")
y = open("data/task1(2).txt")

with x, y:
    x_file = x.readlines()
    y_file = y.readlines()
    for i in range(len(x_file)):
        if x_file[i] != y_file[i]:
            print(x_file[i], y_file[i], sep='')