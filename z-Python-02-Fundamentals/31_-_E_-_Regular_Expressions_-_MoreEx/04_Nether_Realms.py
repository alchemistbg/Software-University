# 100/100

import re

split_pattern = r', *'
letters_pattern = r'[^0-9\+\-*\/\.]'
numbers_pattern = r'[+|-]?\d+(\.?(\d)+)?'
operators_pattern = r'[*|\/]'

data = input()
demons_input = re.split(split_pattern, data)
demons = {}

for demon in demons_input:
    demon = demon.strip()
    letters = re.findall(letters_pattern, demon, re.IGNORECASE)
    health = 0
    for letter in letters:
        health += ord(letter)

    numbers = re.finditer(numbers_pattern, demon)
    damage = 0
    for number in numbers:
        damage += float(number[0])

    operators = re.findall(operators_pattern, demon)
    for operator in operators:
        if operator == '*':
            damage = damage * 2
        elif operator == '/':
            damage = damage / 2


    demons[demon] = {
        'health': health,
        'damage': damage
    }

sorted_demons = dict(sorted(demons.items(), key = lambda kvp: kvp[0]))
for demon in sorted_demons:
    print(f"{demon} - {sorted_demons[demon]['health']} health, {sorted_demons[demon]['damage']:.2f} damage")
