from collections import deque


def get_present(searched_level, presents: dict):
    for name, level in presents.items():
        if searched_level == level:
            return name


materials = deque(map(int, input().split()))
magics = deque(map(int, input().split()))

presents_magic = {
    'Doll':	150,
    'Wooden train':	250,
    'Teddy bear':	300,
    'Bicycle': 	400
}

produced_presents = {
    'Doll':	0,
    'Wooden train':	0,
    'Teddy bear':	0,
    'Bicycle': 	0
}

while materials and magics:
    material = materials[-1]
    magic = magics[0]
    magic_level = material * magic

    if magic_level in presents_magic.values():
        present = get_present(magic_level, presents_magic)
        produced_presents[present] += 1
        materials.pop()
        magics.popleft()
    elif magic_level < 0:
        materials.pop()
        magics.popleft()
        new_material = material + magic
        materials.append(new_material)
    elif magic_level > 0 and magic_level not in presents_magic.values():
        magics.popleft()
        materials[-1] += 15
    elif material == 0 and magic == 0:
        materials.pop()
        magics.popleft()
    elif material == 0:
        materials.pop()
    elif magic == 0:
        magics.popleft()

if (produced_presents['Bicycle'] and produced_presents['Wooden train']) or\
        (produced_presents['Teddy bear'] and produced_presents['Bicycle']):
    print("The presents are crafted! Merry Christmas!")
else:
    print('No presents this Christmas!')

if materials:
    materials.reverse()
    print(f'Materials left: {", ".join(map(str, materials))}')

if magics:
    print(f'Magic left: {", ".join(map(str, magics))}')

produced_presents = dict(sorted(produced_presents.items()))
for present, qty in produced_presents.items():
    if qty > 0:
        print(f'{present}: {qty}')
