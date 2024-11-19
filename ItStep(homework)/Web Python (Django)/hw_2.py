
# task 1
def fibonacci_in_range(start, end):
    a, b = 0, 1
    while a <= end:
        if a >= start:
            yield a
        a, b = b, a + b

start = 30
end = 1000
fib_numbers = list(fibonacci_in_range(start, end))
print(fib_numbers)

# task 2
def armstrong_in_range(start, end):
    for num in range(start, end + 1):
        digits = [int(d) for d in str(num)]
        num_digits = len(digits)

        armstrong_sum = sum(d ** num_digits for d in digits)

        if armstrong_sum == num:
            yield num


start = 100
end = 1000
armstrong_numbers = list(armstrong_in_range(start, end))
print(armstrong_numbers)

# task 3

import time

def time_decorator(func):
    def wrapper(*args, **kwargs):
        start_time = time.time()
        result = func(*args, **kwargs)
        end_time = time.time()
        elapsed_time = end_time - start_time
        print(f"Час виконання: {elapsed_time:.5f} секунд")
        return result
    return wrapper

@time_decorator
def get_even_numbers_in_range(start, end):
    return [num for num in range(start, end + 1) if num % 2 == 0]

start = 0
end = 100000
even_numbers = get_even_numbers_in_range(start, end)

print(even_numbers[:100])

# task 4

def square(x):
    return x ** 2

def cube(x):
    return x ** 3

def calculate(list_to_work, function_to_call):
    return [function_to_call(x) for x in list_to_work]

numbers = [1, 2, 3, 4, 5]

choice = input("Введіть 'квадрат' для зведення в квадрат або 'куб' для зведення в куб: ").strip().lower()

try:
    if choice == 'квадрат':
        result = calculate(numbers, square)
    elif choice == 'куб':
        result = calculate(numbers, cube)
    else:
        raise ValueError("Введіть 'квадрат' або 'куб'")
    print(f"Результат: {result}")
except ValueError as e:
    print(e)

# task 5
def format_for_org1(func):
    def wrapper(*args, **kwargs):
        report = func(*args, **kwargs)
        return f"Звіт для Організації 1:\n{report}\n---Кінець звіту для Організації 1---"
    return wrapper

def format_for_org2(func):
    def wrapper(*args, **kwargs):
        report = func(*args, **kwargs)
        return f"--- Організація 2 Звіт ---\n{report}\n======== Кінець звіту ========"
    return wrapper

def format_for_org3(func):
    def wrapper(*args, **kwargs):
        report = func(*args, **kwargs)
        return f"**Фінансова звітність для Організації 3**\n{report}\n**Звіт завершено**"
    return wrapper

def generate_report(data):
    return f"Фінансові дані: {data}"

@format_for_org1
def org1_report(data):
    return generate_report(data)

@format_for_org2
def org2_report(data):
    return generate_report(data)

@format_for_org3
def org3_report(data):
    return generate_report(data)

financial_data = "Прибуток: 5000, Витрати: 2000, Чистий прибуток: 3000"

print(org1_report(financial_data))

print(org2_report(financial_data))

print(org3_report(financial_data))




