# 100/100

from collections import deque

total_food = int(input())
orders = deque(map(int, input().split()))

max_order = max(orders)
print(max_order)

while total_food > 0:
    if len(orders) == 0:
        break
        
    order = orders[0]
    if order <= total_food:
        orders.popleft()
        total_food -= order
    else:
        # The logic here is not very clear but it works
        break

if len(orders) == 0:
    print('Orders complete')
else:
    print(f'Orders left: {" ".join(map(str, orders))}')
