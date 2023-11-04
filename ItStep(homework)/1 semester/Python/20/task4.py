with open("data/task4.txt", encoding='utf-8') as x:
    m_len = 0
    n = 0
    for i in x:
        if len(i) > m_len:
            m_len = len(i)
        n += 1
    print(f"{n} рядок - найдовший, в ному {m_len} символів")