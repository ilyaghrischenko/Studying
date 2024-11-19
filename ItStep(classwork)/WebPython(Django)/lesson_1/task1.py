fruits = ('banana', 'apple', 'bananamango', 'mango', 'strawberry-banana')
user_input = input("Enter a fruit: ")

count_full = 0
count_partial = 0

for fruit in fruits:
    if fruit == user_input:
        count_full += 1
    if user_input in fruit:
        count_partial += 1

print(f"Full matches: {count_full}")
print(f"Partial matches: {count_partial}")