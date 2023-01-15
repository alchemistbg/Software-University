# 100/100

persons_count = int(input())
total_days = int(input())

food_price = 2
water_price = 3
monster_price = 20

total_profit = 0

current_day = 1

while current_day <= total_days:
    if current_day % 10 == 0:
        persons_count -= 2

    if current_day % 15 == 0:
        persons_count += 5
        total_profit -= persons_count * 2

    total_profit += 50
    total_profit -= persons_count * food_price

    if current_day % 3 == 0:
        total_profit -= persons_count * water_price

    if current_day % 5 == 0:
        total_profit += persons_count * monster_price

    current_day += 1

profit_per_person = total_profit // persons_count
print(f'{persons_count} companions received {profit_per_person} coins each.')

# 100/100 - This is almost identical to old solution
# persons_count = int(input())
# days = int(input())
#
# food_price = 2
# water_price = 3
# monster_price = 20
#
# total_profit = 0
#
# for day in range (1, days + 1):
#
#     if day % 10 == 0:
#         persons_count -= 2
#
#     if day % 15 == 0:
#         persons_count += 5
#         total_profit -= persons_count * 2
#
#     total_profit += 50
#     total_profit -= persons_count * food_price
#
#     if day % 3 == 0:
#         total_profit -= persons_count * water_price
#
#     if day % 5 == 0:
#         total_profit += persons_count * monster_price
#
#     # if days % 3 == 0 and days % 5 == 0:
#     #     total_profit -= persons_count * 2
#
#     days -= 1
#
# profit_per_person = total_profit // persons_count
# print(f'{persons_count} companions received {profit_per_person} coins each.')
