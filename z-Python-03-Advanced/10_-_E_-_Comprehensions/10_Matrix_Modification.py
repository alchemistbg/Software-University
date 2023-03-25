# 100/100

size = int(input())

matrix = [[int(n) for n in input().split()] for i in range(size)]

while True:
    command = input()

    if command == 'END':
        break

    action, r, c, diff = command.split()
    r, c, diff = int(r), int(c), int(diff)

    if r >= len(matrix) or r < 0 or c >= len(matrix[0]) or c < 0:
        print('Invalid coordinates')
        continue

    if action == "Add":
        matrix[r][c] += diff
    elif action == 'Subtract':
        matrix[r][c] -= diff


[print(' '.join(map(str, row))) for row in matrix]
