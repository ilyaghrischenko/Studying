x = open("data/task2(1).txt", encoding='utf-8')
y1 = open("data/task2(2).txt", "w", encoding='utf-8')

with x, y1:
    numbers = 0
    ryad = 0
    gol = 0
    pr = 0
    sym = 0
    x_file = x.readlines()
    
    for i in x_file:
        for j in i:
            if j.isdigit():
                numbers += 1
            if j.isalpha():
                if j.lower() in 'аеєиіїоу':
                    gol += 1
                else:
                    pr += 1
                sym += 1
        ryad += 1
    
    y1.write(f"Кількість символів: {sym}\nКількість рядків: {ryad}\nКількість голосних літер: {gol}\nКількість приголосних літер: {pr}\nКількість цифр: {numbers}")
