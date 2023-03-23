# 100/100

rows = int(input())
matrix = [[int(elem) for elem in input().split(', ')] for row in range(rows)]

# Original version
# main_diag = [matrix[i][j] for i in range(len(matrix)) for j in range(len(matrix[i])) if i == j]

# Shorter version
main_diag = [matrix[i][i] for i in range(len(matrix))]
main_diag_sum = sum(main_diag)
print(f'Primary diagonal: {", ".join(map(str, main_diag))}. Sum: {main_diag_sum}')

sec_diag = [matrix[len(matrix) - j - 1][j] for j in range(len(matrix) - 1, -1, -1)]
sec_diag_sum = sum(sec_diag)
print(f'Secondary diagonal: {", ".join(map(str, sec_diag))}. Sum: {sec_diag_sum}')
