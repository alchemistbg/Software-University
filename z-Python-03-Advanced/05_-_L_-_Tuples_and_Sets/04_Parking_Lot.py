# 100/100

count = int(input())

cars = set()

for _ in range(count):
    direction, reg_plate = input().split(', ')
    operations = {
        'IN': cars.add,
        'OUT': cars.remove
    }
    operations[direction](reg_plate)
    # if direction == 'IN':
    #     cars.add(car)
    # else:
    #     cars.remove(car)

if len(cars) > 0:
    print('\n'.join(cars))
else:
    print('Parking Lot is Empty')