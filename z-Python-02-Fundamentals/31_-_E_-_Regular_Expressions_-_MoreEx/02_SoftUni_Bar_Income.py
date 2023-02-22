# 100/100

import re

pattern = r'%([A-Z][a-z]+)%[^\|\$%\.]*<(\w+)>[^\|\$%\.]*\|(\d+)\|[A-Za-z^\|\$%\.]*(\d+(\.\d+)*)\$'

income = 0

while True:
    line = input()
    if line == 'end of shift':
        break

    matches = re.finditer(pattern, line)
    for match in matches:
        name = match[1]
        product = match[2]
        qty = int(match[3])
        single_price = float(match[4])
        total_price = qty * single_price
        income += total_price

        print(f'{name}: {product} - {total_price:.2f}')

print(f'Total income: {income:.2f}')
