# 100/100

def get_sequence_middle(seq):
    return len(seq) // 2


sequence = input().split()

total_moves = 0

while True:
    line = input()

    if line == 'end':
        print('Sorry you lose :(')
        print(' '.join(sequence))
        break
    else:
        total_moves += 1
        idx1, idx2 = list(map(int, line.split()))
        if idx1 == idx2 or idx1 < 0 or idx1 >= len(sequence) or idx2 < 0 or idx2 >= len(sequence):
            print('Invalid input! Adding additional elements to the board')
            middle_idx = get_sequence_middle(sequence)
            sequence.insert(middle_idx, f'{-total_moves}a')
            sequence.insert(middle_idx + 1, f'{-total_moves}a')
        elif sequence[idx1] == sequence[idx2]:
            # This approach uses only indexes to remove duplicated elements
            # print(f'Congrats! You have found matching elements - {sequence[idx1]}!')
            # idx1_rem = min(idx1, idx2)
            # idx2_rem = max(idx1, idx2)
            # sequence.pop(idx2_rem)
            # sequence.pop(idx1_rem)

            # This approach uses list comprehension (no 1) or filter (no 2) to remove duplicated elements
            match = sequence[idx1]
            print(f'Congrats! You have found matching elements - {match}!')
            # 1. List comprehension
            # sequence = [ch for ch in sequence if ch != match]
            # 2. Filter function
            sequence = list(filter(lambda ch: ch != match, sequence))

            if not sequence:
                print(f'You have won in {total_moves} turns!')
                break
        elif sequence[idx1] != sequence[idx2]:
            print('Try again!')
