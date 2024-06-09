def check_rhythm(stroka):
    # Список гласных букв
    vowels = 'аеёиоуыэюя'

    # Разделение строки на фразы
    phrases = stroka.split()

    # Проверка количества фраз
    if len(phrases) < 2:
        return "Количество фраз должно быть больше одной!"

    # Функция для подсчета гласных в слове
    def count_vowels(word):
        return sum(1 for char in word if char in vowels)
    
    # Подсчет гласных в каждой фразе
    syllable_counts = [sum(count_vowels(word) for word in phrase.split('-')) for phrase in phrases]
    
    # Проверка, одинаковое ли количество гласных в каждой фразе
    if all(count == syllable_counts[0] for count in syllable_counts):
        return "Парам пам-пам"
    else:
        return "Пам парам"

# Пример использования функции
stroka = 'пара-ра-рам рам-пам-папам па-ра-па-дам'
print(check_rhythm(stroka))
