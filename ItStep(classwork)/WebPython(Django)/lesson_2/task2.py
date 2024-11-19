def gen_get_numbers_in_range(arr, start, end):
    for i in arr:
        if start <= i <= end:
            yield i

arr = [i for i in range(1,21)]
for i in gen_get_numbers_in_range(arr, 5, 10):
    print(i)
