# 100/100

# Could be done in one line, but the readability will be awful
rows, colums = list(map(int, input().split()))
[print(" ".join([f'{chr(r + 97)}{chr(r + c + 97)}{chr(r + 97)}' for c in range(colums)])) for r in range(rows)]