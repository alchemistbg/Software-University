# 100/100

items = input().split('|')
initial_budget = float(input())
current_budget = initial_budget

total_profit = 0.0
sell_prices = []
travel_limit = 150.0

for item in items:
    item_type, item_price = item.split('->')
    item_price = float(item_price)

    is_valid_item = (
        (item_type == 'Clothes' and item_price <= 50.00) or
        (item_type == 'Shoes' and item_price <= 35.00) or
        (item_type == 'Accessories' and item_price <= 20.50)
    )

    if is_valid_item and current_budget >= item_price:
        current_budget -= item_price

        current_profit = item_price * 0.4
        total_profit += current_profit

        sell_price = item_price + current_profit
        sell_prices.append(sell_price)

sell_prices = list(map('{:.2f}'.format, sell_prices))
print(" ".join(sell_prices))

print(f'Profit: {total_profit:.2f}')

if initial_budget + total_profit >= travel_limit:
    print('Hello, France!')
else:
    print('Not enough money.')
