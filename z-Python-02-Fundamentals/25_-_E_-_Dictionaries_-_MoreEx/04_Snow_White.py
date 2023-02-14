# 100/100

dwarfs = {}
hair_colors = {}

while True:
    data = input()
    if data == 'Once upon a time':
        break

    name, hair_color, physics = data.split(' <:> ')
    dict_key = name + hair_color
    physics = int(physics)

    if not dwarfs.get(dict_key):
        dwarfs[dict_key] = {
            'name': name,
            'hair_color': hair_color,
            'physics': physics
        }

        if not hair_colors.get(hair_color):
            hair_colors[hair_color] = 0
        hair_colors[hair_color] += 1
    else:
        dwarfs[dict_key]['physics'] = max(dwarfs[dict_key]['physics'], physics)

for dwarf in dwarfs:
    d_hc = dwarfs[dwarf]['hair_color']
    dwarfs[dwarf]['total_hair_color'] = hair_colors[d_hc]

sorted_dwarfs = dict(sorted(dwarfs.items(), key = lambda kvp: (-kvp[1]['physics'], -kvp[1]['total_hair_color'])))
for dwarf in sorted_dwarfs:
    print(f'({sorted_dwarfs[dwarf]["hair_color"]}) {sorted_dwarfs[dwarf]["name"]} <-> {sorted_dwarfs[dwarf]["physics"]}')
