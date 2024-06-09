def sum(a, b):
    # Базовый случай: если одно из чисел равно нулю, возвращаем другое число
    if a == 0:
        return b
    elif b == 0:
        return a
    # Рекурсивный случай: уменьшаем a на 1 и увеличиваем b на 1
    else:
        return sum(a - 1, b + 1)

# Примеры
print(sum(2, 2))  # 4
print(sum(0, 5))  # 5
print(sum(3, 7))  # 10
