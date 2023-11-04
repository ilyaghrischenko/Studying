x = open("data/file.txt")
y1 = open("data/file1.txt", "w")
y2 = open("data/file1.txt")

n = int(input("1 - * на &\n2 - & на *\n\n"))

with x, y1, y2:
    x_file = x.read()
    print(x_file, "\nПочатковий файл")
    
    if n == 1:
        y1.write(x_file.replace("*", "&"))
    elif n == 2:
        y1.write(x_file.replace("&", "*"))
    
    y1.close()
    
    y_file = y2.read()
    print(y_file, "\nЗмінений файл")