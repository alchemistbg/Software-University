# NOT FINISHED

# deco_qty = int(input())
# days_to_xmas = int(input())
#
# budget = 0
# spirit = 0
#
# ornament_set_qty = days_to_xmas // 2
# ornament_set_expenses = ornament_set_qty * 2 * deco_qty
# ornament_set_spirit = ornament_set_qty * 5
#
# tree_skirt_qty = days_to_xmas // 3
# tree_skirt_expenses = tree_skirt_qty * 5 * deco_qty
# tree_skirt_spirit = tree_skirt_qty * 3
#
# tree_garland_qty = days_to_xmas // 3
# tree_garland_expenses = tree_garland_qty * 3 * deco_qty
# tree_garland_spirit = tree_garland_qty * 10
#
# tree_lights_qty = days_to_xmas // 5
# tree_lights_expenses = tree_lights_qty * 15 * deco_qty
# tree_lights_spirit = tree_lights_qty * 17
#
# tree_lights_spirit_premium = days_to_xmas // 15 * 30
#
# cat_extra_expenses = 23 * days_to_xmas // 10
# cat_spirit_loss = days_to_xmas // 10 * 20
#
# budget = ornament_set_expenses + tree_skirt_expenses + tree_garland_expenses + tree_lights_expenses + cat_extra_expenses
# spirit = ornament_set_spirit + tree_skirt_spirit + tree_garland_spirit + tree_lights_spirit +\
#          tree_lights_spirit_premium - cat_spirit_loss
#
# print(f"Total cost: {budget}")
# print(f"Total spirit: {spirit}")

# THIS IS AN OLD SOLUTION AND IT WORKS 100/100
qty = int(input())
days = int(input())

ornament = 2
skirt = 5
garland = 3
light = 15

totalCost = 0
totalSpirit = 0
passedDays = 0

while days > 0:
    days -= 1
    passedDays += 1

    if passedDays % 11 == 0:
        qty += 2

    if passedDays % 2 == 0:
        totalCost += qty * ornament
        totalSpirit += 5

    if passedDays % 3 == 0:
        totalCost += qty * (skirt + garland)
        totalSpirit += 13

    if passedDays % 5 == 0:
        totalCost += qty * light
        totalSpirit += 17

        if passedDays % 3 == 0:
            totalSpirit += 30

    if passedDays % 10 == 0:
        totalCost += skirt + garland + light
        totalSpirit -= 20
        if days == 0:
            totalSpirit -= 30

print(f"Total cost: {totalCost}")
print(f"Total spirit: {totalSpirit}")
