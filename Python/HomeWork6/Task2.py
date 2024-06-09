# Пример
a1 = 2
d = 3
n = 4
def arithmetic_progression(a1, d, n):
    progression = []
    for i in range(n):
        an = a1 + i * d
        progression.append(an)
    return progression

progression = arithmetic_progression(a1, d, n)
for value in progression:
    print(value)
