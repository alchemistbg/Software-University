# 100/100
# The solution is translated from C# using this:
# https://pastebin.com/Gu2hp9Ez

from collections import deque

bullet_price = int(input())
gun_barrel_size = int(input())
bullets = deque(map(int, input().split()))
locks = deque(map(int, input().split()))
intelligence_value = int(input())

shoot_counter = 0
total_bullets_price = 0
profit = 0

while locks and bullets:
    bullet = bullets.pop()
    shoot_counter += 1
    lock = locks[0]

    if lock >= bullet:
        print('Bang!')
        locks.popleft()
    else:
        print('Ping!')

    if shoot_counter % gun_barrel_size == 0 and len(bullets) > 0:
        print('Reloading!')


total_bullets_price = shoot_counter * bullet_price
if locks:
    print(f'Couldn\'t get through. Locks left: {len(locks)}')
else:
    profit = intelligence_value - total_bullets_price
    print(f'{len(bullets)} bullets left. Earned ${profit}')
