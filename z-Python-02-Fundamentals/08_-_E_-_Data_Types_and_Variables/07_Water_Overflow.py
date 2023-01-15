# 100/100

counter = int(input())

tank_capacity = 255
tank_volume = 0

while counter > 0:
    water = int(input())
    if tank_capacity - water >= 0:
        tank_capacity -= water
        tank_volume += water
    else:
        print('Insufficient capacity!')
    counter -= 1

print(tank_volume)
