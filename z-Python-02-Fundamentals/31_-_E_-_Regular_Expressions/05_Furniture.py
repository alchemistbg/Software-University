# 100/100

import re

pattern = r'>>([a-zA-Z]+)<<([\d]+(\.[\d]+)?)!([\d]+)'
products = []
total_cost = 0

while True:
    line = input()

    if line == 'Purchase':
        break

    match = re.fullmatch(pattern, line)
    if match:
        product = match[1]
        single_price = float(match[2])
        qty = int(match[4])
        total_price = qty * single_price
        products.append(product)
        total_cost += total_price

print('Bought furniture:')
[print(p) for p in products]
print(f'Total money spend: {total_cost:.2f}')
