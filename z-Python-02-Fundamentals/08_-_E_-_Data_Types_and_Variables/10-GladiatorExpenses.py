# 100/100

lost_games_count = int(input())

helmet_price = float(input())
sword_price = float(input())
shield_price = float(input())
armor_price = float(input())

current_game = 1

expenses = 0

while current_game <= lost_games_count:

    if current_game % 2 == 0:
        expenses += helmet_price

    if current_game % 3 == 0:
        expenses += sword_price

    if current_game % 6 == 0:
        expenses += shield_price

    if current_game % 12 == 0:
        expenses += armor_price

    current_game += 1

print(f'Gladiator expenses: {expenses:.2f} aureus')
