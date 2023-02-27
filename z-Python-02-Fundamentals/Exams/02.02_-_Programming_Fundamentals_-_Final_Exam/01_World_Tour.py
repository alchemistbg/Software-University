# 100/100

destinations = list(input())

while True:
    line = input()

    if line == 'Travel':
        break

    if line.startswith('Add'):
        command, idx, stop = line.split(':')
        idx = int(idx)
        for i, ch in enumerate(stop):
            destinations.insert(idx + i, ch)
    elif line.startswith('Remove'):
        command, start_idx, end_idx = line.split(':')
        start_idx = int(start_idx)
        end_idx = int(end_idx)
        if 0 <= start_idx < len(destinations) and 0 <= end_idx < len(destinations):
            destinations = [destinations[i] for i in range(len(destinations)) if not start_idx <= i <= end_idx]
    elif line.startswith('Switch'):
        command, old, new = line.split(':')
        temp = ''.join(destinations)
        temp = temp.replace(old, new)
        destinations = list(temp)

    print(''.join(destinations))

print(f'Ready for world tour! Planned stops: {"".join(destinations)}')

