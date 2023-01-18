# 100/100

budget = float(input())
statists = int(input())
clothes_price = float(input())

movie_cost = 0

decor_cost = budget * 0.1
total_clothes_cost = statists * clothes_price
if statists > 150:
    total_clothes_cost *= 0.9

movie_cost = decor_cost + total_clothes_cost
diff = budget - movie_cost

if diff >= 0:
    print('Action!')
    print(f'Wingard starts filming with {diff:.2f} leva left.')
else:
    print('Not enough money!')
    print(f'Wingard needs {abs(diff):.2f} leva more.')
