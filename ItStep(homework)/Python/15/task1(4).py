#4
import random

x = []
y = []
my_list = []

for i in range(15):
    x.append(random.randint(-10, 10))
    y.append(random.randint(-10, 10))

print(f"Перший список - {x}\nДругий список - {y}\n")

for i in range(len(x)):
    if x[i] not in y:
        my_list.append(x[i])

for i in range(len(y)):
    if y[i] not in x:
        my_list.append(y[i])

print(f"4) Сформувати третій список, що містить тільки унікальні елементи кожного зі списків\n{my_list}")
print(f"Кількість елементів у списку: {len(my_list)}\n")
#Так як у завданні не було сказано "без повторів", я не вказував цього в коді. Тобто якщо є декілька однакових унікальніх елементів в 1 спсику, яких НЕМАЄ в 2, то вони будуть добавлені декалька разів.