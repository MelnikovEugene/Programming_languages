def max_berries(arr):
    n = len(arr)
    if n < 3:
        return sum(arr)  # Если кустов меньше 3, то сумма всех кустов

    max_berries = 0

    for i in range(n):
        # Считаем ягоды для куста i и его двух соседей
        current_sum = arr[i] + arr[i-1] + arr[(i+1) % n]
        # Обновляем максимальное значение
        max_berries = max(max_berries, current_sum)

    return max_berries

# Пример использования
arr = [5, 8, 6, 4, 9, 2, 7, 3]
print(max_berries(arr))  # Вывод: 19
