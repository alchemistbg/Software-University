from collections import deque
from datetime import datetime, timedelta


def log_robot(log: deque, robot_data: str):
    log.append(robot_data)


free_robots = deque()
working_robots = []
waiting_products = deque()
log = deque()

is_from_queue = False

raw_data = input().split(';')
for robot in raw_data:
    name, processing_time = robot.split('-')
    processing_time = int(processing_time)
    free_robots.append((name, processing_time))

start_time = datetime.strptime(input(), '%H:%M:%S')

while True:
    data = input()
    if data == 'End':
        break

    waiting_products.append(data)

seconds = 0
while len(waiting_products) > 0:
    seconds += 1

    product = waiting_products.pop()

    if len(free_robots) > 0:
        free_robot = free_robots.popleft()
        if not is_from_queue:
            current_time = (start_time + timedelta(seconds = seconds)).time()
        else:
            time = datetime.strptime(f'{current_time}', '%H:%M:%S')
            current_time = (time + timedelta(seconds = free_robot[1])).time()
        log_record = f'{free_robot[0]} - {product} [{current_time}]'
        log_robot(log, log_record)
        working_robots.append(free_robot)
        working_robots.sort(key = lambda robot_data: -robot_data[1])
    else:
        waiting_products.append(product)

        last_robot_processing_time = working_robots[-1][1]
        if seconds % last_robot_processing_time == 0:
            free_robot = working_robots.pop()
            free_robots.append(free_robot)
            is_from_queue = True

print('\n'.join(log))
