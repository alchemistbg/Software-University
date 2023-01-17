# 100/100

strawberry_price = float(input())

banana_qty = float(input())
orange_qty = float(input())
raspberry_qty = float(input())
strawberry_qty = float(input())

raspberry_price = strawberry_price * 0.5
orange_price = raspberry_price * 0.6
banana_price = raspberry_price * 0.2

total_banana_price = banana_qty * banana_price
total_orange_price = orange_qty * orange_price
total_raspberry_price = raspberry_qty * raspberry_price
total_strawberry_price = strawberry_qty * strawberry_price

total_fruit_price = total_banana_price + total_orange_price + total_raspberry_price + total_strawberry_price

print(f'{total_fruit_price:.2f}')