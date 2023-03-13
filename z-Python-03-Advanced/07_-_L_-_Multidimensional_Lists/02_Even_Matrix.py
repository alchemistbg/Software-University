rows = int(input())

matrix = []

for _ in range(rows):
    data = list(map(int, input().split(', ')))
    row = [d for d in data if d % 2 == 0]
    # for d in data:
    #     if d % 2 == 0:
    #         row.append(d)
    matrix.append(row)
    # matrix.append(list(filter(lambda x: x % 2 == 0, data)))

print(matrix)
