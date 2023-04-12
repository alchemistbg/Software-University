# 100/100

def is_in_board(r, c):
    return 0 <= r < 8 and 0 <= c < 8


def find_king(board):
    for r in range(len(board)):
        for c in range (len(board[r])):
            if board[r][c] == 'K':
                return [r, c]


board = []

for _ in range(8):
    line = list(input().split())
    board.append(line)

deadly_queens = []

directions = {
    "down": (1, 0),
    "up": (-1, 0),
    "right": (0, 1),
    "left": (0, -1),
    "down-right": (1, 1),
    "down-left": (1, -1),
    "up-right": (-1, 1),
    "up-left": (-1, -1),
}

for direction in directions:
    temp_row, temp_col = find_king(board)

    for _ in range(8):
        temp_row = temp_row + directions[direction][0]
        temp_col = temp_col + directions[direction][1]

        if is_in_board(temp_row, temp_col):
            if board[temp_row][temp_col] == 'Q':
                deadly_queens.append([temp_row, temp_col])
                break
        else:
            break

if deadly_queens:
    for deadly_queen in deadly_queens:
        print(deadly_queen)
else:
    print('The king is safe!')
