# Заданные список и число k
list_1 = [1, 2, 3, 4, 5]
k = 3

# Инициализация счетчика
count_k = 0

# Проход по каждому элементу списка
for item in list_1:
    # Если элемент равен k, увеличиваем счетчик
    if item == k:
        count_k += 1

# Вывод результата
print(count_k)