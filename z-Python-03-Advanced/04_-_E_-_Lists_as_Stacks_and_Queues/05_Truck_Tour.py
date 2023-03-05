# 100/100

from collections import deque

circle_size = int(input())
stations = deque()

for _ in range(circle_size):
    litters, distance = map(int, input().split())
    stations.append((litters, distance))

tank_content = 0
station_counter = 0
best_station = 0

while len(stations) > 0:
    station = stations.popleft()
    l, d = station
    tank_content += (l - d)
    station_counter += 1

    if tank_content < 0:
        tank_content = 0
        best_station = station_counter

print(best_station)
