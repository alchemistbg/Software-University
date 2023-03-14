rows = columns = int(input())

matrix = []

for r in range(rows):
    row = list(map(int, input().split(' ')))
    matrix.append(row)

# If it is square matrix, the second loop could be omitted.
prime_diag_sum = 0
for c in range(rows):
    for r in range(columns):
        if r == c:
            prime_diag_sum += matrix[r][c]

print(prime_diag_sum)
