# 100/100
# This could be refactored. TODO

def get_snake_pos(field):
    snake_pos = []
    for i in range(len(field)):
        for j in range(len(field[i])):
            if field[i][j] == "S":
                snake_pos.extend([i, j])
    return snake_pos


def get_lair_pos(field):
    lair = []
    for i in range(len(field)):
        for j in range(len(field[i])):
            if field[i][j] == "B":
                lair.append([i, j])
    return lair


size = int(input())
field = [list(input()) for i in range(size)]
lair_pos = get_lair_pos(field)
food_qty = 0
won = False

while True:
    row, col = get_snake_pos(field)
    field[row][col] = '.'
    move = input()
    if move == 'left':
        col -= 1
    elif move == 'right':
        col += 1
    elif move == 'up':
        row -= 1
    elif move == 'down':
        row += 1

    if (row < 0 or row > len(field) - 1 or col < 0 or col > len(field[0]) - 1):
        break

    if field[row][col] == '*':
        food_qty += 1

    if food_qty >= 10:
        field[row][col] = 'S'
        won = True
        break

    if [row, col] in lair_pos:
        entrance = lair_pos.index([row, col])
        field[row][col] = '.'
        exit = lair_pos[abs(1 - entrance)]
        row, col = exit

    field[row][col] = 'S'

if won:
    print("You won! You fed the snake.")
else:
    print("Game over!")
print(f'Food eaten: {food_qty}')
[print(''.join(row)) for row in field]