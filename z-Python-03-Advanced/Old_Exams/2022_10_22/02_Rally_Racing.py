# https://judge.softuni.org/Contests/Practice/Index/3596#1
# 100/100
# Some code could be separate as functions

def print_matrix(matrix):
    for r in range(len(matrix)):
        print(''.join(matrix[r]))

def get_tunnel_exit(r, c):
    for m_row in range(len(matrix)):
        for m_col in range(len(matrix[m_row])):
            if matrix[m_row][m_col] == 'T' and (r != m_row or c != m_col):
                return m_row, m_col


size = int(input())
car_number = input()

matrix = []
for n in range(size):
    row = input().split()
    matrix.append(row)

traveled_distance = 0
car_position = [0, 0]
finished = False

while True:
    direction = input()
    if direction == 'End':
        break
    elif direction == 'left':
        car_position[1] -= 1
    elif direction == 'right':
        car_position[1] += 1
    elif direction == 'up':
        car_position[0] -= 1
    elif direction == 'down':
        car_position[0] += 1

    r, c = car_position
    if matrix[r][c] == '.':
        traveled_distance += 10
    elif matrix[r][c] == 'T':
        exit_r, exit_c = get_tunnel_exit(r, c)
        matrix[r][c] = '.'
        matrix[exit_r][exit_c] = '.'
        car_position = [exit_r, exit_c]
        traveled_distance += 30
    elif matrix[r][c] == 'F':
        finished = True
        traveled_distance += 10
        break

r, c = car_position
matrix[r][c] = 'C'
if finished:
    print(f'Racing car {car_number} finished the stage!')
else:
    print(f'Racing car {car_number} DNF.')
print(f'Distance covered {traveled_distance} km.')
print_matrix(matrix)
