# 100/100

from collections import deque

water_volume = int(input())
queue = deque()

while True:
    line = input()
    if line == 'End':
        break

    if line == 'Start':
        pass
    elif 'refill' in line:
        command, refill_volume = line.split()
        refill_volume = int(refill_volume)
        water_volume += refill_volume
    elif line.isnumeric():
        order = int(line)
        name = queue.popleft()
        if water_volume >= order:
            water_volume -= order
            print(f'{name} got water')
        else:
            print(f'{name} must wait')
    else:
        queue.append(line)

print(f'{water_volume} liters left')
