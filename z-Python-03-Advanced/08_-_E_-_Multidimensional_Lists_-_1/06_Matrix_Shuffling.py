# 100/100

def create_matrix():
    rows, cols = list(map(int, input().split()))
    matrix = []
    for r in range (rows):
        row = input().split()
        matrix.append(row)
    return matrix


def validate_command(matrix, command):
    rows = len(matrix)
    cols = len(matrix[0])
    tokens = command.split()
    if tokens[0] != 'swap':
        return False
    elif len(tokens) != 5:
        return False
    elif not tokens[1].isdigit() and not tokens[2].isdigit() and not tokens[3].isdigit() and not tokens[4].isdigit():
        return False
    elif (int(tokens[1]) > rows or int(tokens[1]) < 0) or (int(tokens[2]) > rows or int(tokens[2]) < 0) or\
            (int(tokens[3]) > rows or int(tokens[3]) < 0) or (int(tokens[4]) > rows or int(tokens[4]) < 0):
        return False
    return True


def print_matrix(matrix):
    for r in range(len(matrix)):
        row = matrix[r]
        print(' '.join(row))


def shuffle_matrix(matrix, coordinates):
    r1, c1, r2, c2 = list(map(int, coordinates))
    temp = matrix[r1][c1]
    matrix[r1][c1] = matrix[r2][c2]
    matrix[r2][c2] = temp
    return matrix


matrix = create_matrix()
while True:
    command = input()
    if command == "END":
        break

    is_valid = validate_command(matrix, command)
    if is_valid:
        coordinates = command.split()[1:]
        matrix = shuffle_matrix(matrix, coordinates)
        print_matrix(matrix)
    else:
        print('Invalid input!')

# print_matrix(matrix)