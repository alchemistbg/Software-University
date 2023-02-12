# 100/100
# Could be refactored a bit more - e.g. with if/else clauses

parking = {}

counter = int(input())

for _ in range(counter):
    tokens = input().split()
    command = tokens[0]
    username = tokens[1]

    if command == 'register':
        plate = tokens[2]

        if username not in parking.keys():
            parking[username] = plate
            print(f'{username} registered {plate} successfully')
        else:
            print(f'ERROR: already registered with plate number {plate}')
    else:
        if username not in parking.keys():
            print(f'ERROR: user {username} not found')
        else:
            parking.pop(username)
            print(f'{username} unregistered successfully')

[print(f'{name} => {plate}') for (name, plate) in parking.items()]