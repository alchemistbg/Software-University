# 100/100
# Maybe could be refactored a little bit - TODO

MISSING = 'null'
counter = int(input())

dragons = {}
dragons_stat = {}

for _ in range(counter):

    dragon_type, name, damage, health, armor = input().split()
    dragon_key = dragon_type + name
    if damage == MISSING:
        damage = 45
    else:
        damage = int(damage)

    if health == MISSING:
        health = 250
    else:
        health = int(health)

    if armor == MISSING:
        armor = 10
    else:
        armor = int(armor)

    if not dragons.get(dragon_key):
        dragons[dragon_key] = {
            'name': name,
            'type': dragon_type,
            'damage': damage,
            'health': health,
            'armor': armor
        }
    else:
        dragons_stat[dragon_type]['total_count'] -= 1
        dragons_stat[dragon_type]['total_damage'] -= dragons[dragon_key]['damage']
        dragons_stat[dragon_type]['total_health'] -= dragons[dragon_key]['health']
        dragons_stat[dragon_type]['total_armor'] -= dragons[dragon_key]['armor']

        dragons[dragon_key]['damage'] = damage
        dragons[dragon_key]['health'] = health
        dragons[dragon_key]['armor'] = armor

    if not dragons_stat.get(dragon_type):
        dragons_stat[dragon_type] = {
            'total_count': 1,
            'total_damage': damage,
            'total_health': health,
            'total_armor': armor
        }
    else:
        dragons_stat[dragon_type]['total_count'] += 1
        dragons_stat[dragon_type]['total_damage'] += damage
        dragons_stat[dragon_type]['total_health'] += health
        dragons_stat[dragon_type]['total_armor'] += armor

sorted_dragons = dict(sorted(dragons.items(), key = lambda kvp: kvp[0]))

for dr_type in dragons_stat:
    avg_damage = dragons_stat[dr_type]['total_damage'] / dragons_stat[dr_type]['total_count']
    avg_health = dragons_stat[dr_type]['total_health'] / dragons_stat[dr_type]['total_count']
    avg_armor = dragons_stat[dr_type]['total_armor'] / dragons_stat[dr_type]['total_count']
    print(f'{dr_type}::({avg_damage:.2f}/{avg_health:.2f}/{avg_armor:.2f})')

    for dragon in sorted_dragons:
        curr_dragon = sorted_dragons[dragon]
        if curr_dragon['type'] == dr_type:
            print(f'-{curr_dragon["name"]} -> damage: {curr_dragon["damage"]}, health: {curr_dragon["health"]}, armor: {curr_dragon["armor"]}')
