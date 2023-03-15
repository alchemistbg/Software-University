def create_init_matrix():
    matrix = []

    rows, columns = list(map(int, input().split(', ')))

    for r in range(rows):
        row = list(map(int, input().split(', ')))
        matrix.append(row)
    return matrix


def get_squares(matrix):
    squares = []
    for i in range(len(matrix) - 1):
        row = matrix[i]
        for j in range(len(row) - 1):
            square = [
                matrix[i][j:j + 2],
                matrix[i + 1][j:j + 2]
            ]
            squares.append(square)
    return squares


def calc_square_sum(square):
    square_sum = 0
    for r in range(len(square)):
        square_sum += sum(square[r])
    return square_sum


def print_square(square):
    for i in square:
        print(' '.join(list(map(str, i))))


def get_max_square(squares):
    max_square = []
    max_square_sum = 0

    for curr_square in squares:
        curr_square_sum = calc_square_sum(curr_square)
        if curr_square_sum > max_square_sum:
            max_square_sum = curr_square_sum
            max_square = curr_square

    return max_square


matrix = create_init_matrix()
squares = get_squares(matrix)
max_square = get_max_square(squares)

print_square(max_square)
print(calc_square_sum(max_square))