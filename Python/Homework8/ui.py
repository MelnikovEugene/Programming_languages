from logger import input_data, print_data, search_data, edit_data, delete_data

def interface():
    print("Добрый день! Вы попали на специальный бот справочник от GeekBrains.\n" 
          "1 - запись данных\n"
          "2 - вывод данных\n"
          "3 - поиск данных\n"
          "4 - изменение данных\n"
          "5 - удаление данных")
    command = int(input('Введите число\n'))

    while command not in [1, 2, 3, 4, 5]:
        print("Вы ввели неверное число")
        command = int(input('Введите число \n'))
    
    if command == 1:
        input_data()
    elif command == 2:
        print_data()
    elif command == 3:
        search_data()
    elif command == 4:
        edit_data()
    elif command == 5:
        delete_data()