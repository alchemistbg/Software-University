# 100/100

budget = float(input())
fuel_qty = float(input())
day = input()

fuel_price = 2.1
guide_price = 100

total_cost = 0.0

fuel_cost = fuel_qty * fuel_price

total_cost = fuel_cost + guide_price

if day == 'Saturday':
    total_cost *= 0.9
else:
    total_cost *= 0.8

diff = abs(budget - total_cost)

if budget >= total_cost:
    print(f'Safari time! Money left: {diff:.2f} lv.')
else:
    print(f'Not enough money! Money needed: {diff:.2f} lv.')
