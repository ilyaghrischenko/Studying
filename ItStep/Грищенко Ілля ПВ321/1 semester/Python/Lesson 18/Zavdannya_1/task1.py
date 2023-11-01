x = open("data/task1(1).txt")
file_x = x.read()

file_x = file_x.replace('.', ' ')
file_x = file_x.replace(',', ' ')

file_x = file_x.split()

mas = []

for i in file_x:
    if len(i) >= 7:
       mas.append(i)
       
p = ''
for i in mas:
    p += i
    p += ' '
    
y = open("data/task1(2).txt", "w")
y.write(p)
y.close()

y = open("data/task1(2).txt")
print(y.read())