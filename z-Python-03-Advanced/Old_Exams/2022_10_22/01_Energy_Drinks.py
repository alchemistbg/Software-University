# https://judge.softuni.org/Contests/Practice/Index/3596#0
# 100/100

from collections import deque

coffeines = deque(map(int, input().split(', ')))
drinks = deque(map(int, input().split(', ')))

total_coffeine = 0

while True:
    if not coffeines or not drinks:
        break
    coffeine = coffeines.pop()
    drink = drinks.popleft()
    current_coffeine = coffeine * drink
    if total_coffeine + current_coffeine <= 300:
        total_coffeine += current_coffeine
    else:
        drinks.append(drink)
        if total_coffeine - 30 > 0:
            total_coffeine -= 30

if drinks:
    print(f"Drinks left: {', '.join(list(map(str, drinks)))}")
else:
    print("At least Stamat wasn't exceeding the maximum caffeine.")
print(f"Stamat is going to sleep with {total_coffeine} mg caffeine.")
