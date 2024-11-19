import random as rnd

first = tuple(rnd.randint(1, 2) for i in range(10))
second = tuple(rnd.randint(1, 2) for i in range(10))
third = tuple(rnd.randint(1, 2) for i in range(10))

print("First tuple:", first)
print("Second tuple:", second)
print("Third tuple:", third)

common = tuple(set(first) & set(second) & set(third))
print(f"Common values: {common}")

unique = tuple(set(first) - set(second) - set(third))
print(f"Unique values: {unique}")

elements = []
for i in range(len(first)):
    if first[i] == second[i] == third[i]:
        elements.append(first[i])
elements = tuple(elements)
print(f"Elements: {elements}")
