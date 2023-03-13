def calc_matrix_sum(matrix: list):
    matrix_sum = 0
    for r in range(len(matrix)):
        for c in range(len(matrix[r])):
            matrix_sum += matrix[r][c]
    return matrix_sum


matrix = []
# matrix_sum = 0

rows,columns = map(int, input().split(', '))

for _ in range(rows):
    row = list(map(int, input().split(', ')))
    matrix.append(row)
    # row_sum = sum(row)
    # matrix_sum += row_sum

# print(matrix_sum)
print(calc_matrix_sum(matrix))
print(matrix)
