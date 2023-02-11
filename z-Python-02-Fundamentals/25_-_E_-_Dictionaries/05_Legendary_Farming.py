# 100/100 - I don't like this solution! It is very complicated!!! Need to be refactored!!!

legendary_items = {
    'shards': 'Shadowmourne',
    'fragments': 'Valanyr',
    'motes': 'Dragonwrath'
}

key_materials = {
    'shards': 0,
    'fragments': 0,
    'motes': 0
}

junk_materials = {}

while True:
    materials = input().split()

    items = list(map(str.lower, materials[1::2]))
    qtys = list(map(int, materials[0::2]))

    end = False

    for (idx, item) in enumerate(items):
        if item in key_materials.keys():
            key_materials[item] += qtys[idx]

            if key_materials[item] >= 250:
                key_materials[item] -= 250
                print(f'{legendary_items[item]} obtained!')
                [print(f'{mat}: {qty}') for mat, qty in key_materials.items()]
                [print(f'{mat}: {qty}') for mat, qty in junk_materials.items()]

                end = True
                break
        else:
            if item not in junk_materials:
                junk_materials[item] = 0
            junk_materials[item] += qtys[idx]

    if end:
        break
