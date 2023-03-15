# 100/100

def create_matrix():
    matrix = []

    rows = cols = int(input())
    for r in range(rows):
        row = list(map(int, input().split(', ')))
        matrix.append(row)
    return matrix


def get_primary_diag(matrix):
    prim_diag = []
    for r in range(len(matrix)):
        prim_diag.append(matrix[r][r])
    return prim_diag


def get_secondary_diag(matrix):
    sec_diag = []
    for r in range(len(matrix) - 1, -1, -1):
        sec_diag.append(matrix[len(matrix) - r - 1][r])
    return sec_diag


def calc_diag_sum(diag):
    return sum(diag)


matrix = create_matrix()
prim_diag = get_primary_diag(matrix)
prim_diag_sum = calc_diag_sum(prim_diag)
sec_diag = get_secondary_diag(matrix)
sec_diag_sum = calc_diag_sum(sec_diag)

print(f'Primary diagonal: {", ".join(map(str, prim_diag))}. Sum: {prim_diag_sum}')
print(f'Secondary diagonal: {", ".join(map(str, sec_diag))}. Sum: {sec_diag_sum}')
