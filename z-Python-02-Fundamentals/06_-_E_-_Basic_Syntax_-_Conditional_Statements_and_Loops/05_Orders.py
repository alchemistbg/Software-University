# 100/100

orders_qty = int(input())

orders_counter = 0
IS_CORRECT = True

total_price = 0.0

while orders_counter < orders_qty:
    price_per_capsules = float(input())
    if price_per_capsules < 0.01 or price_per_capsules > 100:
        IS_CORRECT = False

    days = int(input())
    if days < 1 or days > 31:
        IS_CORRECT = False

    capsules_per_day = int(input())
    if capsules_per_day < 1 or capsules_per_day > 2000:
        IS_CORRECT = False

    if IS_CORRECT:
        current_price = price_per_capsules * days * capsules_per_day
        total_price += current_price
        print(f'The price for the coffee is: ${current_price:.2f}')

    IS_CORRECT = True
    orders_counter += 1

print(f'Total: ${total_price:.2f}')
