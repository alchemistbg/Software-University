# 100/100

products = {}

while True:
    input_data = input()
    if input_data == 'statistics':
        break

    product, qty = input_data.split()
    qty = int(qty)

    if product not in products.keys():
        products[product] = qty
    else:
        products[product] += qty

count_products = len(products.keys())
sum_count_products = sum(products.values())

print('Products in stock:')
# [print(f' - {key} {products[key]}') for key in products.keys()] # This is cumbersome
[print(f' - {product} {quantity}') for (product, quantity) in products.items()] # This is more readable
print(f'Total Products: {count_products}')
print(f'Total Quantity: {sum_count_products}')
