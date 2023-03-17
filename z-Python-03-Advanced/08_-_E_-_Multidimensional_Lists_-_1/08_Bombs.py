# 100/100

def create_matrix():
    matrix = []
    size = int(input())
    for r in range(size):
        row = list(map(int, input().split()))
        matrix.append(row)
    return matrix


def read_coordinates():
    coordinates = []
    tokens = input().split()
    for coordinate in tokens:
        r, c = list(map(int, coordinate.split(',')))
        coordinates.append([r, c])
    return coordinates


def make_explosion(matrix, coordinates):
    size = len(matrix)
    for coordinate in coordinates:
        r, c = coordinate
        if matrix[r][c] > 0:
            value = matrix[r][c]
            matrix[r][c] = 0
            for r_a in range(r-1, r + 2):
                for c_a in range(c-1, c + 2):
                    if 0 <= r_a < size and 0 <= c_a < size and matrix[r_a][c_a] > 0:
                        matrix[r_a][c_a] -= value


def get_live_cells(matrix):
    size = len(matrix)
    live_cells = []
    for r in range(size):
        for c in range(size):
            if matrix[r][c] > 0:
                live_cells.append(matrix[r][c])
    return live_cells


def print_matrix(matrix):
    for r in range(len(matrix)):
        row = matrix[r]
        print(' '.join(map(str, row)))


matrix = create_matrix()
coordinates = read_coordinates()
make_explosion(matrix, coordinates)
active_cells = get_live_cells(matrix)

print(f'Alive cells: {len(active_cells)}')
print(f'Sum: {sum(active_cells)}')
print_matrix(matrix)
