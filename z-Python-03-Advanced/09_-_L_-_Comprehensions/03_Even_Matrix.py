# 100/100

lines = int(input())
matrix = []
for _ in range (lines):
    matrix.append([int(n) for n in input().split(', ')])

m = [[col for col in row if col % 2 == 0] for row in matrix]
print(m)