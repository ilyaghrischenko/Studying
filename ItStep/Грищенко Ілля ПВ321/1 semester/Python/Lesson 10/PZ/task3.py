word_w_v = ""
x = input("Введіть слово: ")
for i in x:
    if i == "a" or i == "e" or i == "i" or i == "o" or i == "u":
        continue
    else:
        word_w_v += i
print(word_w_v)