# 100/100

budget = float(input())

price_flour = float(input())
price_eggs = price_flour * 0.75
price_milk = price_flour * 1.25 / 4

price_bread = price_flour + price_eggs + price_milk

bread_counter = 0
colored_eggs = 0

while budget >= price_bread:
    bread_counter += 1
    colored_eggs += 3
    if bread_counter % 3 == 0:
        colored_eggs -= bread_counter - 2
    budget -= price_bread

print(f'You made {bread_counter} loaves of Easter bread! Now you have {colored_eggs} eggs and {budget:.2f}BGN left.')
