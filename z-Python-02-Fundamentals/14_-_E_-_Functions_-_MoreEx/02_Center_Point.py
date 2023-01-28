# 100/100

import math


def calc_distance_to_center(point):
    distance_to_center = math.sqrt((point[0] - 0)**2 + (point[1] - 0)**2)
    return distance_to_center


def find_closer_point(p1, p2):
    distance1 = calc_distance_to_center(p1)
    distance2 = calc_distance_to_center(p2)

    if distance1 > distance2:
        return f'({math.floor(p2[0])}, {math.floor(p2[1])})'

    return f'({math.floor(p1[0])}, {math.floor(p1[1])})'


x1 = float(input())
y1 = float(input())
x2 = float(input())
y2 = float(input())

point1 = (x1, y1)
point2 = (x2, y2)

result = find_closer_point(point1, point2)
print(result)
