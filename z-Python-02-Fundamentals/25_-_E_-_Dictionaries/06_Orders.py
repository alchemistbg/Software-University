# 100/100

products = {}

while True:
    data = input()
    if data == 'buy':
        break
    product, price, qty = data.split()
    price = float(price)
    qty = int(qty)

    if product not in products.keys():
        products[product] = [0, 0]

    products[product][0] = price
    products[product][1] += qty

for product, product_data in products.items():
    print(f'{product} -> {product_data[0] * product_data[1]:.2f}')
