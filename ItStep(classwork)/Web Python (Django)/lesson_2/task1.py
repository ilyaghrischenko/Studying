def gen_parn_chisl(start, end):
    for i in range(start, end):
        if i % 2 == 0:
            yield i

for i in gen_parn_chisl(10, 20):
    print(i)
