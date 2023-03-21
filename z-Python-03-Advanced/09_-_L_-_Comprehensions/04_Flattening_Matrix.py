# 100/100

lines = int(input())
# matrix = []
# for _ in range (lines):
#     row = list(map(int, input().split(', ')))
#     matrix.append(row)
#
# flat_matrix = [num for row in matrix for num in row]
# print(flat_matrix)

# One line solution
print([int(num) for _ in range(lines) for num in input().split(', ')])
