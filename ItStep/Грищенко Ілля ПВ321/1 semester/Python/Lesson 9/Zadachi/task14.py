n = int(input("Введіть м за 1 хв: "))
vid = int(input("Введіть відсоток: "))/100
h = int(input("Введіть бажану глибину: "))

hv = 0
score = 0

while score <= h:
    score += n
