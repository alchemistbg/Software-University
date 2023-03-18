# 100/100
# Some ideas taken from: https://pastebin.com/PtpQuN6f

def create_lair():
    rows, cols = list(map(int, input().split()))
    lair = []
    for r in range(rows):
        row = list(input())
        lair.append(row)
    return lair


def get_pos(lair, qry):
    qry_pos = [0, 0]
    for r in range(len(lair)):
        row = lair[r]
        if qry in row:
            qry_pos = [r, row.index(qry)]
    return qry_pos


def get_moves():
    moves = list(input())
    return moves


def get_bunnies(lair):
    bunnies = []
    for r in range(len(lair)):
        row = lair[r]
        for c in range(len(row)):
            if lair[r][c] == 'B':
                bunnies.append([r, c])
    return bunnies


def make_bunnies(lair):
    bunnies = get_bunnies(lair)
    for bunny in bunnies:
        b_r, b_c = bunny
        if b_r + 1 < len(lair):
            lair[b_r + 1][b_c] = 'B'
        if b_r - 1 >= 0:
            lair[b_r - 1][b_c] = 'B'
        if b_c + 1 < len(lair[b_r]):
            lair[b_r][b_c + 1] = 'B'
        if b_c - 1 >= 0:
            lair[b_r][b_c - 1] = 'B'


def check_is_neighbor(cell1, cell2):
    if cell1 == cell2:
        return True


def check_is_outside(lair, pos):
    lair_rows = len(lair)
    lair_cols = len(lair[0])
    return pos[0] < 0 or pos[1] < 0 or pos[0] >= lair_rows or pos[1] >= lair_cols


def make_moves(lair, moves):
    result = ''
    player_pos = get_pos(lair, 'P')
    for idx, move in enumerate(moves):
        old_pos = get_pos(lair, 'P')
        current_pos = make_move(lair, player_pos, move)
        make_bunnies(lair)
        bunnies = get_bunnies(lair)

        if check_is_outside(lair, current_pos):
            result = f'won: {old_pos[0]} {old_pos[1]}'
            return result
        else:
            for bunny in bunnies:
                if check_is_neighbor(bunny, current_pos):
                    result = f'dead: {current_pos[0]} {current_pos[1]}'
                    return result
    return result


def make_move(lair, current_pos, move):
    old_r, old_c = current_pos
    if (old_r >= 0 and old_c >= 0) and (old_r < len(lair) and old_c < len(lair[0])):
        lair[old_r][old_c] = '.'
    if move == 'U':
        current_pos[0] -= 1
    elif move == 'D':
        current_pos[0] += 1
    elif move == 'L':
        current_pos[1] -= 1
    elif move == 'R':
        current_pos[1] += 1
    curr_r, curr_c = current_pos
    if (curr_r >= 0 and curr_c >= 0) and (curr_r < len(lair) and curr_c < len(lair[0])):
        if lair[curr_r][curr_c] != 'B':
            lair[curr_r][curr_c] = 'P'
            # print(4 + '2')
        #     pass
        # else:
        #     lair[curr_r][curr_c] = 'P'
    return current_pos


def print_lair(lair):
    for row in lair:
        print(''.join(row))


lair = create_lair()
player_start_pos = get_pos(lair, 'P')
bunny_pos = get_pos(lair, 'B')
moves = get_moves()
result = make_moves(lair, moves)
print_lair(lair)
print(result)


