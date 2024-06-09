list_1 = [-5, 9, 0, 3, -1, -2, 1, 4, -2, 10, 2, 0, -9, 8, 10, -9, 0, -5, -5, 7]
min_number = 0
max_number = 10

def find_indices_in_range(list_1, min_number, max_number):
    indices = []
    for i in range(len(list_1)):
        if min_number <= list_1[i] <= max_number:
            indices.append(i)
    return indices
indices = find_indices_in_range(list_1, min_number, max_number)
for index in indices:
    print(index)
