# 100/100


size = int(input())


def create_field():
    field = []

    for r in range(size):
        row = input().split()
        field.append(row)

    return field


def create_moves():
    moves = input().split()
    return moves


def get_start_point(field):
    start = [0, 0]

    for r in range(len(field)):
        row = field[r]
        if 's' in row:
            start = [r, row.index('s')]

    return start


def get_field_value(field, position):
    row, col = position
    return field[row][col]


def get_coal(field, position):
    row, col = position
    field[row][col] = '*'
    return field

def get_total_coal(field):
    coal_total = 0

    for r in range(len(field)):
        row = field[r]
        current_coal = row.count('c')
        coal_total += current_coal

    return coal_total


def make_move(current_pos, move):
    if move == 'up' and 1 <= current_pos[0]:
        current_pos[0] -= 1
    elif move == 'down' and current_pos[0] < size - 1:
        current_pos[0] += 1
    elif move == 'left' and 1 <= current_pos[1]:
        current_pos[1] -= 1
    elif move == 'right' and current_pos[1] < size - 1:
        current_pos[1] += 1

    return current_pos


def make_moves(field, moves):
    # res = ''
    coal_collected = 0
    coal_total = get_total_coal(field)
    for idx, move in enumerate(moves):
        if idx == 0:
            current_pos = make_move(start, move)
        else:
            current_pos = make_move(current_pos, move)

        field_value = get_field_value(field, current_pos)

        if field_value == 'c':
            coal_collected += 1
            field = get_coal(field, current_pos)
            if coal_total == coal_collected:
                res = f'You collected all coal! ({current_pos[0]}, {current_pos[1]})'
                break
        elif field_value == 'e':
            res = f'Game over! ({current_pos[0]}, {current_pos[1]})'
            break
    else:
        res = f'{coal_total - coal_collected} pieces of coal left. ({current_pos[0]}, {current_pos[1]})'

    return res


# This function prints the field in more readable format. It is not necessary for the solution.
def print_field(field):
    for row in field:
        print(' '.join(row))


moves = create_moves()
field = create_field()
start = get_start_point(field)
result = make_moves(field, moves)
print(result)

# This next line calls a function that prints the field after the game is finished
# print_field(field)
