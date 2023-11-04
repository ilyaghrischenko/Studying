x = open("data/file.txt")
y1 = open("data/file1.txt", "a")
y2 = open("data/file1.txt")
t = open("data/file2.txt")

with x, y1, y2, t:
    x_file = x.read()
    print("Початковий файл", x_file, sep='\n')
    print()
    t_file = t.read()
    t_file = t_file.split()
    y_file = x_file.split()
    print("Неприйнятні слова", t_file, sep='\n')
    print()
    
    new_file_y = []
    for i in y_file:
        for j in t_file:
            if i == j:
                break
            else:
                new_file_y.append(i)
                break
    print(new_file_y)
        
    f = ''
    for i in new_file_y:
        f += i
    
    y1.write(f)
    
    y1.close()
    print("Новий файл", y2.read(), sep='\n')