rows, columns = list(map(int, input().split(', ')))

matrix = []

for r in range(rows):
    row = list(map(int, input().split(' ')))
    matrix.append(row)

# print(matrix)
for c in range(columns):
    col_sum = 0
    for r in range(rows):
        col_sum += matrix[r][c]
    print(col_sum)