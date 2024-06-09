# Заданные список и число k
list_1 = [1, 2, 3, 4, 5]
k = 6

# Инициализация переменных для хранения самого близкого элемента и минимальной разницы
closest_value = list_1[0]
min_difference = abs(list_1[0] - k)

# Проход по каждому элементу списка
for item in list_1:
    # Вычисление разницы между текущим элементом и k
    difference = abs(item - k)
    # Если текущая разница меньше минимальной разницы, обновляем значения
    if difference < min_difference:
        min_difference = difference
        closest_value = item

# Вывод результата
print(closest_value)
