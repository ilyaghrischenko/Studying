def check_value(check_value, func):
    return func(check_value)

def is_even(value):
    return value % 2 == 0

def is_odd(value):
    return value % 2 != 0

number = 10
print(check_value(number, is_even))
print(check_value(number, is_odd))
