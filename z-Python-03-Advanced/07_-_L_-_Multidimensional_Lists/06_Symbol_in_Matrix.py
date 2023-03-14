def find_symbol(matrix, qry):
    for r in range (len(matrix)):
        for c in range (len(matrix[r])):
            if matrix[r][c] == qry:
                return r, c


rows = columns = int(input())

matrix = []

for r in range(rows):
    row = list(input())
    matrix.append(row)

query = input()
coordinates = find_symbol(matrix, query)

if coordinates:
    print(coordinates)
else:
    print(f'{query} does not occur in the matrix')
