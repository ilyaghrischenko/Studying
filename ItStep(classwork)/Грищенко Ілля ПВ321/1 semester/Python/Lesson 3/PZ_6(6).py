hours = int(input("Введіть годину: "))
minut = int(input("Введіть хвилини: "))
vidr = int(input("Введіть відрізок часу: "))

print(f"1st Time {hours}:{minut}", f"Відрізок часу {vidr} хвилин", sep="\n")

all_minut = hours * 60 + minut + vidr
hours = int(all_minut / 60) % 24
minut = all_minut % 60

print(f"2nd Time {hours}:{minut}")