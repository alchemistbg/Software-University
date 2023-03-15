# 100/100

def create_matrix():
    matrix = []
    rows = cols = int(input())
    for r in range(rows):
        row = list(map(int, input().split()))
        matrix.append(row)
    return matrix


def get_diagonal(matrix, type):
    diag = []
    size = len(matrix)
    if type == 'primary':
        for r in range(size):
            diag.append(matrix[r][r])
    elif type == 'secondary':
        for r in range(size - 1, -1, -1):
            diag.append(matrix[size - r - 1][r])
        pass
    return diag


def calc_diag_sum(diag):
    return sum(diag)


matrix = create_matrix()
prim_diag = get_diagonal(matrix, 'primary')
prim_diag_sum = calc_diag_sum(prim_diag)
sec_diag = get_diagonal(matrix, 'secondary')
sec_diag_sum = calc_diag_sum(sec_diag)
print(abs(prim_diag_sum - sec_diag_sum))