# https://judge.softuni.org/Contests/Practice/Index/3744#1
# 100/100

def get_submarine_position():
    for r in range(len(field)):
        for c in range(len(field[r])):
            if field[r][c] == 'S':
                return [r, c]


def print_field():
    for r in range(len(field)):
        print(''.join(field[r]))

size = int(input())
field = []
for _ in range(size):
    field.append(list(input()))

submarine_position = get_submarine_position()
init_r, init_c = submarine_position
field[init_r][init_c] = '-'
mines = 0
ships = 0

while True:
    if mines >= 3 or ships >= 3:
        field[curr_r][curr_c] = 'S'
        break

    command = input()
    if command == 'left':
        submarine_position[1] -= 1
    elif command == 'right':
        submarine_position[1] += 1
    elif command == 'up':
        submarine_position[0] -= 1
    elif command == 'down':
        submarine_position[0] += 1

    curr_r, curr_c = submarine_position
    if field[curr_r][curr_c] == '*':
        mines += 1
    elif field[curr_r][curr_c] == 'C':
        ships += 1
    field[curr_r][curr_c] = '-'


final_r, final_c = get_submarine_position()
if mines >= 3:
    print(f'Mission failed, U-9 disappeared! Last known coordinates [{final_r}, {final_c}]!')
elif ships >= 3:
    print('Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!')
print_field()