x = ["Hello fkgjfgds\g", "fsdgfgqafgw'3rfsd", "fg9348hjusfdasf", "asdasqd"]
y1 = open("data/file1.txt", "w")
y2 = open("data/file1.txt")

with y1, y2:
    x = x[::-1]
    for i in x:
        i = i[::-1]
        y1.writelines(i)
        y1.writelines("\n")    
    y1.close()
    y_file = y2.read()
    print(y_file)      