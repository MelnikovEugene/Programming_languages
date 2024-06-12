from data_create import name_data, surname_data, phone_data, address_data

def input_data():
    name = name_data()
    surname = surname_data()
    phone = phone_data()
    address = address_data()
    var = int(input(f"В каком формате записать данные?\n \n" 
    f"1 Вариант:\n" 
    f"{name}\n{surname}\n{phone}\n{address}\n\n" 
    f"2 Вариант:\n" 
    f"{name};{surname};{phone};{address}\n\n"  
    f"Выберите вариант: "))
    
    while var !=1 and var !=2:
        print("Вы ввели неверное число")
        var = int(input('Введите номер варианта \n'))
    
    if var == 1:
        with open('c:/Users/Elemental/Desktop/GeekBrains/Programming languages/Python/Homework8/data_first_variant.csv', 'a', encoding='utf-8') as f:
            f.write(f"{name}\n{surname}\n{phone}\n{address}\n\n")
    elif var == 2:
        with open('c:/Users/Elemental/Desktop/GeekBrains/Programming languages/Python/Homework8/data_second_variant.csv', 'a', encoding='utf-8') as f:
            f.write(f"{name};{surname};{phone};{address}\n\n")


def print_data():
    print('Вывожу данные из 1 файла: \n')
    with open('c:/Users/Elemental/Desktop/GeekBrains/Programming languages/Python/Homework8/data_first_variant.csv', 'r', encoding='utf-8') as f:
        data_first = f.readlines()
        data_first_list = []
        j = 0
        for i in range(len(data_first)):
            if data_first[i] == '\n' or i == len(data_first)-1:
                data_first_list.append(' '.join(data_first[j:i+1]))
                j = i
    print(''.join(data_first_list))
    
    print('Вывожу данные из 2 файла: \n')
    with open('c:/Users/Elemental/Desktop/GeekBrains/Programming languages/Python/Homework8/data_second_variant.csv', 'r', encoding='utf-8') as f:
        data_second = f.readlines()
        print(*data_second)

def search_data():
    criterion = input("Введите характеристику для поиска (имя или фамилию): ").strip()
    found_records = []
    
    with open('c:/Users/Elemental/Desktop/GeekBrains/Programming languages/Python/Homework8/data_first_variant.csv', 'r', encoding='utf-8') as f:
        data_first = f.readlines()
    
    with open('c:/Users/Elemental/Desktop/GeekBrains/Programming languages/Python/Homework8/data_second_variant.csv', 'r', encoding='utf-8') as f:
        data_second = f.readlines()
    
    for line in data_first + data_second:
        if criterion.lower() in line.lower():
            found_records.append(line.strip())
    
    if found_records:
        print("Найденные записи:")
        for record in found_records:
            print(record)
    else:
        print("Записи не найдены.")

def edit_data():
    search_data()
    record_to_edit = input("Введите точное имя или фамилию записи для изменения: ").strip()
    
    data_first_path = 'c:/Users/Elemental/Desktop/GeekBrains/Programming languages/Python/Homework8/data_first_variant.csv'
    data_second_path = 'c:/Users/Elemental/Desktop/GeekBrains/Programming languages/Python/Homework8/data_second_variant.csv'
    
    with open(data_first_path, 'r', encoding='utf-8') as f:
        data_first = f.readlines()
    
    with open(data_second_path, 'r', encoding='utf-8') as f:
        data_second = f.readlines()
    
    data_first_updated = []
    data_second_updated = []
    
    record_found = False
    
    for line in data_first:
        if record_to_edit.lower() in line.lower():
            print(f"Текущая запись: {line.strip()}")
            name = input('Введите новое имя: ')
            surname = input('Введите новую фамилию: ')
            phone = input('Введите новый номер телефона: ')
            address = input('Введите новый адрес: ')
            data_first_updated.append(f"{name}\n{surname}\n{phone}\n{address}\n\n")
            record_found = True
        else:
            data_first_updated.append(line)
    
    for line in data_second:
        if record_to_edit.lower() in line.lower():
            print(f"Текущая запись: {line.strip()}")
            name = input('Введите новое имя: ')
            surname = input('Введите новую фамилию: ')
            phone = input('Введите новый номер телефона: ')
            address = input('Введите новый адрес: ')
            data_second_updated.append(f"{name};{surname};{phone};{address}\n\n")
            record_found = True
        else:
            data_second_updated.append(line)
    
    with open(data_first_path, 'w', encoding='utf-8') as f:
        f.writelines(data_first_updated)
    
    with open(data_second_path, 'w', encoding='utf-8') as f:
        f.writelines(data_second_updated)
    
    if not record_found:
        print("Запись не найдена.")

def delete_data():
    search_data()
    record_to_delete = input("Введите точное имя или фамилию записи для удаления: ").strip()
    
    data_first_path = 'c:/Users/Elemental/Desktop/GeekBrains/Programming languages/Python/Homework8/data_first_variant.csv'
    data_second_path = 'c:/Users/Elemental/Desktop/GeekBrains/Programming languages/Python/Homework8/data_second_variant.csv'
    
    with open(data_first_path, 'r', encoding='utf-8') as f:
        data_first = f.readlines()
    
    with open(data_second_path, 'r', encoding='utf-8') as f:
        data_second = f.readlines()
    
    data_first_updated = []
    data_second_updated = []
    
    record_found = False
    
    for line in data_first:
        if record_to_delete.lower() in line.lower():
            print(f"Удаление записи: {line.strip()}")
            record_found = True
        else:
            data_first_updated.append(line)
    
    for line in data_second:
        if record_to_delete.lower() in line.lower():
            print(f"Удаление записи: {line.strip()}")
            record_found = True
        else:
            data_second_updated.append(line)
    
    with open(data_first_path, 'w', encoding='utf-8') as f:
        f.writelines(data_first_updated)
    
    with open(data_second_path, 'w', encoding='utf-8') as f:
        f.writelines(data_second_updated)
    
    if not record_found:
        print("Запись не найдена.")

