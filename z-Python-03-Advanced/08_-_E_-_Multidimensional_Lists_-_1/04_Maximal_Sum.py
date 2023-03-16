# 100/100

from itertools import chain


def create_matrix():
    matrix = []
    rows, cols = list(map(int, input().split()))
    for r in range(rows):
        row = list(map(int, input().split()))
        matrix.append(row)
    return matrix


def calc_square_sum(square):
    return sum(chain(*square))


def get_squares(matrix, size):
    squares = []
    for r in range(len(matrix) - (size - 1)):
        row = matrix[r]
        for c in range(len(row) - (size - 1)):
            square = [
                matrix[r + n][c:c + size]
                for n in range(size)
                # matrix[r+1][c:c + size],
                # matrix[r+2][c:c + size],
            ]
            squares.append(square)
    return squares


def get_max_square(squares):
    max_sum = 0
    max_square = []
    for square in squares:
        current_sum = calc_square_sum(square)
        if current_sum >= max_sum:
            max_sum = current_sum
            max_square = square
    return max_square


def print_square(square):
    for row in square:
        print(' '.join(map(str, row)))


matrix = create_matrix()
squares = get_squares(matrix, 3)
max_square = get_max_square(squares)
max_square_sum = calc_square_sum(max_square)
print(f'Sum = {max_square_sum}')
print_square(max_square)
