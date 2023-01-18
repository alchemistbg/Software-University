# 100/100

rent = int(input())

statuette_price = 0.7 * rent
catering_price = 0.85 * statuette_price
sound_price = 0.5 * catering_price

total_cost = rent + statuette_price + catering_price + sound_price

print(f'{total_cost:.2f}')
