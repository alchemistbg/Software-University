from collections import deque
from datetime import datetime, timedelta

robots = {}

robots_data = input().split(';')
for robot_data in robots_data:
    name, working_time = robot_data.split('-')
    available_at = 0
    robots[name] = {
        'working_time': int(working_time),
        'available_at': available_at
    }

start_time = datetime.strptime(input(), '%H:%M:%S')

products = deque()
while True:
    data = input()
    if data == 'End':
        break

    products.append(data)

seconds = 0
while len(products) > 0:
    seconds += 1

    product = products.popleft()

    for robot_name in robots:
        if robots[robot_name]['available_at'] <= seconds:
            robots[robot_name]['available_at'] = robots[robot_name]['working_time'] + seconds
            start_production_time = (start_time + timedelta(seconds = seconds)).strftime('%H:%M:%S')
            print(f'{robot_name} - {product} [{start_production_time}]')
            break
    else:
        products.append(product)



