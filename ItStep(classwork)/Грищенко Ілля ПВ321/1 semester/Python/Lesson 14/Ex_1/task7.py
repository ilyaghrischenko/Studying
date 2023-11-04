n = int(input("Введіть кількість: "))

print("   _~_    " * n)
print("  (o o)   " * n)
print(" /  V  \  " * n)
for i in range(1, n + 1):
    print(f"/(  {i}  )\ ", end='')
print()
print("  ^^ ^^   " * n)