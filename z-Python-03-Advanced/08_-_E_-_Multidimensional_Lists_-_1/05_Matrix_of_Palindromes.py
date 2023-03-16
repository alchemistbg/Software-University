# 100/100

def create_matrix():

    rows, cols = list(map(int, input().split()))

    matrix = []
    for r in range(rows):
        row = []
        for c in range(cols):
            end_char = chr(ord('a') + r)
            middle_char = chr(ord('a') + r + c)
            palindrome = f'{end_char}{middle_char}{end_char}'
            row.append(palindrome)
            # print(palindrome, end = ' ')
        matrix.append(row)
        # print()
    return matrix


def print_matrix(matrix):
    for r in range(len(matrix)):
        row = matrix[r]
        print(' '.join(row))


matrix = create_matrix()
print_matrix(matrix)
