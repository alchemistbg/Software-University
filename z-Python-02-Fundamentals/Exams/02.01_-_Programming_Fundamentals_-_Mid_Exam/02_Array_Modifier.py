# 100/100

array = list(map(int, input().split()))

while True:
    line =  input()

    if line == 'end':
        break

    if line.startswith('swap'):
        command, idx1, idx2 = line.split()
        idx1 = int(idx1)
        idx2 = int(idx2)
        array[idx1], array[idx2] = array[idx2], array[idx1]
    elif line.startswith('multiply'):
        command, idx1, idx2 = line.split()
        idx1 = int(idx1)
        idx2 = int(idx2)
        array[idx1] = array[idx1] * array[idx2]
    elif line == 'decrease':
        array = [elem - 1 for elem in array]

print(', '.join(map(str, array)))