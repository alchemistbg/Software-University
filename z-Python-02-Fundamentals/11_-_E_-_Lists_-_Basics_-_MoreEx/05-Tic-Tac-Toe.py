# 100/100

board = []

player1 = 1
player2 = 2
result = ''

for _ in range (3):
    line = [int(x) for x in input().split()]
    board.append(line)

for i in range(3):
    if (
            (board[i][0] == player1 and board[i][1] == player1 and board[i][2] == player1) or
            (board[0][i] == player1 and board[1][i] == player1 and board[2][i] == player1)
    ):
        result = 'First player won'
        break
    elif (
            (board[i][0] == player2 and board[i][1] == player2 and board[i][2] == player2) or
            (board[0][i] == player2 and board[1][i] == player2 and board[2][i] == player2)
    ):
        result = 'Second player won'
        break
    else:
        result = 'Draw!'

if (
        (board[0][0] == player1 and board[1][1] == player1 and board[2][2] == player1) or
        (board[2][0] == player1 and board[1][1] == player1 and board[0][2] == player1)
):
    result = 'First player won'

if (
        (board[0][0] == player2 and board[1][1] == player2 and board[2][2] == player2) or
        (board[2][0] == player2 and board[1][1] == player2 and board[0][2] == player2)
):
    result = 'Second player won'

print(result)