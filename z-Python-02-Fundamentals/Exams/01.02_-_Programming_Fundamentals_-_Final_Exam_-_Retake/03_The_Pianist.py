# https://judge.softuni.org/Contests/Practice/Index/2525#2\
# 100/100

pieces = {}

counter = int(input())
for _i in range(counter):
    piece, composer, key = input().split('|')
    pieces[piece] = [composer, key]

while True:
    command = input()

    if command == 'Stop':
        break

    tokens = command.split('|')
    if tokens[0] == 'Add':
        piece = tokens[1]
        composer = tokens[2]
        key = tokens[3]
        if piece in pieces.keys():
            print(f'{piece} is already in the collection!')
        else:
            pieces[piece] = [composer, key]
            print(f'{piece} by {composer} in {key} added to the collection!')
    elif tokens[0] == 'Remove':
        piece = tokens[1]
        if piece not in pieces.keys():
            print(f'Invalid operation! {piece} does not exist in the collection.')
        else:
            pieces.pop(piece)
            print(f'Successfully removed {piece}!')
    elif tokens[0] == 'ChangeKey':
        piece = tokens[1]
        key = tokens[2]
        if piece not in pieces.keys():
            print(f'Invalid operation! {piece} does not exist in the collection.')
        else:
            pieces[piece][1] = key
            print(f'Changed the key of {piece} to {key}!')

for p, [c, k] in pieces.items():
    print(f"{p} -> Composer: {c}, Key: {k}")
