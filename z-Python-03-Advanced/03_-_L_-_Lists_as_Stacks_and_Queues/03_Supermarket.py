# 100/100

from collections import deque


def print_queue(queue: deque):
    while len(queue) > 0:
        item = queue.popleft()
        print(item)


market_line = deque()

while True:
    line = input()

    if line == 'End':
        break
    elif line == 'Paid':
        print_queue(market_line)
        market_line.clear()
    else:
        market_line.append(line)

print(f'{len(market_line)} people remaining.')