# https://judge.softuni.org/Contests/Practice/Index/2525#1
# 100/100

import re

food_supplies = []
total_calories = 0
pattern = r'(#|\|)(?P<food>[a-zA-Z ]+)(\1)(?P<exp_date>(\d{2})/(\d{2})/(\d{2}))(\1)(?P<cals>\d+)(\1)'
text = input()
matches = re.findall(pattern, text, re.MULTILINE)
for match in matches:
    food = match[1]
    exp_date = match[3]
    calories = match[8]
    total_calories += int(calories)
    food_supplies.append((food, exp_date, calories))

days = total_calories // 2000

print(f'You have food to last you for: {days} days!')
for item in food_supplies:
    print(f'Item: {item[0]}, Best before: {item[1]}, Nutrition: {item[2]}')