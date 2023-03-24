# I cannot test this solution, because the problem is removed from the judge system

inventory = {key:[] for key in input().split(', ')}

while True:
    data = input()

    if data == 'End':
        break

    hero, item, cost = data.split('-')
    if item not in [x[0] for x in inventory[hero]]:
        inventory[hero].append((item, int(cost)))

{print(f'{key} -> Items: {len(value)}, Cost: {sum([v[1] for v in value])}') for key, value in inventory.items()}
