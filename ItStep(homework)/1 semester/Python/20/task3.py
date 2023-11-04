x = open("data/task3(1).txt", encoding='utf-8')
y = open("data/task3(2).txt", "w", encoding='utf-8')

with x, y:
    x_file = x.readlines()
    del x_file[-1]
    text = ''
    for i in x_file:
        text += i
    
    y.write(text)