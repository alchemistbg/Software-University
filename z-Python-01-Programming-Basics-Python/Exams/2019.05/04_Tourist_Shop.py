# 100/100

budget = float(input())

total_products_qty = 0
total_cost = 0.0
diff = 0.0

while True:
    line = input()

    if line == 'Stop':
        print(f'You bought {total_products_qty} products for {total_cost:.2f} leva.')
        break

    product_name = line
    product_price = float(input())

    if (total_products_qty + 1) % 3 == 0:
        product_price *= 0.5

    if product_price > budget:
        diff = product_price - budget
        print('You don\'t have enough money!')
        print(f'You need {diff:.2f} leva!')
        break

    total_products_qty += 1
    budget -= product_price
    total_cost += product_price
