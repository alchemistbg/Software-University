def print_triangle(n):
    for i in range(1, n):
        row = [j for j in range(1, i + 1)]
        print(*row)
    for i in range(n - 1, 0, -1):
        row = [j for j in range(1, i)]
        print(*row)