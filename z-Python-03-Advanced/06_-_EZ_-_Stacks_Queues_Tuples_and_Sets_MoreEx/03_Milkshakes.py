# 100/100
# This solution is done with the help of the following solutions:
# https://github.com/eftenow/SoftUni/blob/main/03_Python%20Advanced/05_stacks_queues_tuples_and_sets_exercise/03_milkshakes.py
# https://github.com/loramoon/SoftUni/blob/master/Python%20Advanced/Stacks%2C%20Queues%2C%20Tuples%20and%20Sets/03.%20Milkshakes

from collections import deque

chocolates = deque(map(int, input().split(', ')))
milk_cups = deque(map(int, input().split(', ')))
prepared_shakes = 0

while chocolates and milk_cups:
    chocolate = chocolates[-1]
    milk_cup = milk_cups[0]

    if chocolate == milk_cup:
        chocolates.pop()
        milk_cups.popleft()
        prepared_shakes += 1
        if prepared_shakes == 5:
            break
    elif chocolate <= 0:
        chocolates.pop()
    elif milk_cup <= 0:
        milk_cups.popleft()
    else:
        chocolates[-1] -= 5
        milk_cups.append(milk_cups.popleft())

if prepared_shakes >= 5:
    print('Great! You made all the chocolate milkshakes needed!')
else:
    print('Not enough milkshakes.')

if chocolates:
    print(f'Chocolate: {", ".join(map(str, chocolates))}')
else:
    print('Chocolate: empty')

if milk_cups:
    print(f'Milk: {", ".join(map(str, milk_cups))}')
else:
    print('Milk: empty')