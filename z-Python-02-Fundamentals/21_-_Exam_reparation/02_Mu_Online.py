# 100/100

health = 100
bitcoins = 0

rooms = input().split('|')
rooms_counter = 1

for room in rooms:
    command, value = room.split()
    value = int(value)

    if command == 'potion':
        health_diff = 0
        if health + value > 100:
            health_diff = 100 - health
            health = 100
        else:
            health_diff = value
            health += value

        print(f'You healed for {health_diff} hp.')
        print(f'Current health: {health} hp.')

    elif command == 'chest':
        bitcoins += value
        print(f'You found {value} bitcoins.')

    else:
        if health - value > 0:
            health -= value
            print(f'You slayed {command}.')
        else:
            print(f'You died! Killed by {command}.')
            print(f'Best room: {rooms_counter}')
            break

    rooms_counter += 1
else:
    print("You've made it!")
    print(f"Bitcoins: {bitcoins}")
    print(f"Health: {health}")
