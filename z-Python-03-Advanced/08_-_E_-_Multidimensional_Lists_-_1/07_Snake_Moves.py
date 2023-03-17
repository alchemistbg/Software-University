# 100/100

from collections import deque

rows, cols = list(map(int, input().split()))
snake = deque(list(input()))

matrix = []

for r in range (rows):
    string = ''
    for c in range(cols):
        ch = snake.popleft()
        string += ch
        snake.append(ch)
    if r % 2 == 0:
        matrix.append(string)
    else:
        matrix.append(string[::-1])

print("".join(matrix))