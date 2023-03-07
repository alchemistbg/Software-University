# 100/100

from collections import deque

cups = deque(map(int, input().split()))
bottles = deque(map(int, input().split()))
wasted_water = 0

while cups and bottles:
    cup = cups.popleft()

    while cup > 0 and bottles:
        bottle = bottles.pop()
        if bottle >= cup:
            wasted_water += (bottle - cup)
        cup -= bottle

if bottles:
    print(f'Bottles: {" ".join(map(str, bottles))}')
if cups:
    print(f'Cups: {" ".join(map(str, cups))}')

print(f'Wasted litters of water: {wasted_water}')
