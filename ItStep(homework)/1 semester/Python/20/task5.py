with open("data/task5.txt", encoding='utf-8') as x:
    n = input("Введіть шукане слово: ")
    k = 0
    for i in x:
        if n in i:
            k += 1
    print(f"Кількість слова в тексті = {k}")