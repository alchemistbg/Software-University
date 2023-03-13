rows = int(input())

flat_matrix = []

for r in range(0, rows):
    row = list(map(int, input().split(', ')))
    for c in row:
        flat_matrix.append(c)

print(flat_matrix)
