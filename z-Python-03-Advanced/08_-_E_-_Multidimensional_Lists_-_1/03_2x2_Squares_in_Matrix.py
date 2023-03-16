# 100/100

from itertools import chain


def create_matrix():
    matrix = []
    rows, cols = list(map(int, input().split()))
    for r in range (rows):
        row = input().split()
        matrix.append(row)
    return matrix


def get_squares(matrix):
    squares = []
    for r in range(len(matrix) - 1):
        row = matrix[r]
        for c in range(len(row) - 1):
            square = [
                matrix[r][c:c + 2],
                matrix[r + 1][c:c + 2]
            ]
            squares.append(square)
    return squares


def count_identical_squares(squares):
    count_of_identical = 0
    for square in squares:
        is_identical = check_is_identical(square)
        if is_identical:
            count_of_identical += 1
    return count_of_identical


def check_is_identical(square):
    s = set(chain(*square))
    return len(s) == 1


matrix = create_matrix()
squares = get_squares(matrix)
print(count_identical_squares(squares))
