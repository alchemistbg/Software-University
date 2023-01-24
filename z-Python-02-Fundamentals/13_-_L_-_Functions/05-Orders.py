# 100/100

COFFEE_PRICE = 1.5
WATER_PRICE = 1
COKE_PRICE = 1.4
SNACKS_PRICE = 2


def calc_order(item, qty):
    order_value = None
    if item == 'coffee':
        item_value = COFFEE_PRICE
    elif item == 'water':
        item_value = WATER_PRICE
    elif item == 'coke':
        item_value = COKE_PRICE
    elif item == 'snacks':
        item_value = SNACKS_PRICE

    order_value = item_value * qty
    return order_value


item_type = input()
item_qty = float(input())
order_price = calc_order(item_type, item_qty)
print(f'{order_price:.2f}')
