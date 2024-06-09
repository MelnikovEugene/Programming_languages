# Входные данные
var1 = '5 4'  # количество элементов первого и второго множества
var2 = '1 3 5 7 9'  # элементы первого множества через пробел
var3 = '2 3 4 5'  # элементы второго множества через пробел

# Парсинг входных данных
n, m = map(int, var1.split())
set1 = set(map(int, var2.split()))
set2 = set(map(int, var3.split()))

# Нахождение пересечения множеств
intersection = set1 & set2

# Сортировка результата
result = sorted(intersection)

# Вывод результата
print(" ".join(map(str, result)))
