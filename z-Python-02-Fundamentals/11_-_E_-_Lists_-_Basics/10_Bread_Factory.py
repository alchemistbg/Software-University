events = input().split('|')
is_completed = True

energy = 100
coins = 100

for idx, event in enumerate(events):
    event_type, event_value = event.split('-')
    event_value = int(event_value)

    if event_type == 'rest':
        energy_diff = 0
        current_energy = energy
        if energy + event_value >= 100:
            energy = 100
        else:
            energy += event_value

        energy_diff = energy - current_energy

        energy_gain = abs(energy_diff)
        print(f'You gained {energy_gain} energy.')
        print(f'Current energy: {energy}.')

    if event_type == 'order':
        if energy >= 30:
            coins += event_value
            energy -= 30
            print(f'You earned {event_value} coins.')
        else:
            energy += 50
            print('You had to rest!')
            # is_completed = False

    if event_type != 'rest' and event_type != 'order':
        if coins >= event_value:
            coins -= event_value
            print(f'You bought {event_type}.')
        else:
            print(f'Closed! Cannot afford {event_type}.')
            is_completed = False
            break

if is_completed:
    print('Day completed!')
    print(f'Coins: {coins}')
    print(f'Energy: {energy}')