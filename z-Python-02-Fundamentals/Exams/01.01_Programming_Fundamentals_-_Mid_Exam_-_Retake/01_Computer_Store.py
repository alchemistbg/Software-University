# 100/100

prices = []
client = None
while True:
    line = input()

    if line == 'special' or line == 'regular':
        client = line
        break

    price = float(line)
    if price < 0:
        print('Invalid price!')
        continue

    prices.append(price)

total = sum(prices)
if total == 0:
    print('Invalid order!')
else:
    taxes = total * 0.2
    taxed_total = total + taxes
    if client == 'special':
        discount = taxed_total * 0.1
        taxed_total -= discount
    print("Congratulations you've just bought a new computer!")
    print(f'Price without taxes: {total:.2f}$')
    print(f'Taxes: {taxes:.2f}$')
    print('-----------')
    print(f'Total price: {taxed_total:.2f}$')