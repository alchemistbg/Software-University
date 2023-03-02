# 100/100
# TODO: improve the code

lines = int(input())

plants = {}

for _ in range(lines):
    plant, rarity = input().split('<->')
    rarity = int(rarity)
    plants[plant] = {'rarity': rarity, 'ratings': []}


while True:
    command = input()

    if command == 'Exhibition':
        break
    else:
        data = command.split(': ')[1].split(' - ')
        plant = data[0]
        if plant not in plants.keys():
            print('error')
            continue

        if command.startswith('Rate'):
            rating = int(data[1])
            plants[plant]['ratings'].append(rating)
        elif command.startswith('Update'):
            rarity = int(data[1])
            plants[plant]['rarity'] = rarity
        elif command.startswith('Reset'):
            plant = command.split(': ')[1]
            plants[plant]['ratings'].clear()

print('Plants for the exhibition:')
for plant in plants:
    avrg_rating = 0
    if len(plants[plant]['ratings']) > 0:
        avrg_rating = sum(plants[plant]['ratings']) / len(plants[plant]['ratings'])

    print(f'- {plant}; Rarity: {plants[plant]["rarity"]}; Rating: {avrg_rating:.2f}')