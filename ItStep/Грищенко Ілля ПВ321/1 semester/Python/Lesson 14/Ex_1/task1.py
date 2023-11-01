x = input("Введіть текст: ")

txt = x[0:2].capitalize()
for i in range(2, len(x)):
    if x[i-2] == "." and x[i-1] == " ":
        str = x[i]
        txt += str.upper()
    else:
        txt += x[i]
print(txt)

c = 0
count_koma = 0
count_oklik = 0
for j in x:
    if j.isdigit() == True:
        c += 1
    elif j.isdigit() == False and j.isalpha() == False and j != " ":
        count_koma += 1
    if j == "!":
        count_oklik += 1
print(f"Кількість цифр: {c}\nКількість розділових знаків: {count_koma}\nКількість знаків оклику: {count_oklik}")