# 100/100

def add_people(n, new_train):
    # last_wagon_idx = len(train) - 1
    # new_train[last_wagon_idx] += n
    new_train[-1] += n # This row replace the above 2 rows
    return new_train


def insert_people(wagon_idx, number_of_people, new_train):
    new_train[wagon_idx] += number_of_people
    return new_train


def leave_people(wagon_idx, number_of_people, new_train):
    new_train[wagon_idx] -= number_of_people
    return new_train


wagons = int(input())
train = [0] * wagons

command = input()

while command != 'End':
    tokens = command.split()
    command_text = tokens[0]
    if command_text == 'add':
        number_of_people = int(tokens[1])
        train = add_people(number_of_people, train)

    if command_text == 'insert':
        wagon_idx = int(tokens[1])
        number_of_people = int(tokens[2])
        train = insert_people(wagon_idx, number_of_people, train)

    if command_text == 'leave':
        wagon_idx = int(tokens[1])
        number_of_people = int(tokens[2])
        train = leave_people(wagon_idx, number_of_people, train)

    command = input()

print(train)
