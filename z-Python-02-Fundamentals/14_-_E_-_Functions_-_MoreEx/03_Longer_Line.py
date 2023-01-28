# 100/100

import math


def calc_distance(p1, p2):
    sq1 = (p1[0] - p2[0]) ** 2
    sq2 = (p1[1] - p2[1]) ** 2
    distance = math.sqrt(sq1 + sq2)
    return distance


def compare_lines(l1, l2):
    l1_length = calc_distance(l1[0], l1[1])
    l2_length = calc_distance(l2[0], l2[1])

    if l1_length < l2_length:
        return l2
    return l1


def format_coordinates(line):
    center = (0, 0)
    point1 = line[0]
    point2 = line[1]
    d1 = calc_distance(point1, center)
    d2 = calc_distance(point2, center)
    formatted_point1 = f'({math.floor(point1[0])}, {math.floor(point1[1])})'
    formatted_point2 = f'({math.floor(point2[0])}, {math.floor(point2[1])})'

    formatted_line = f'{formatted_point1}{formatted_point2}'
    if d1 > d2:
        formatted_line = f'{formatted_point2}{formatted_point1}'

    return formatted_line


x1 = float(input())
y1 = float(input())
x2 = float(input())
y2 = float(input())
x3 = float(input())
y3 = float(input())
x4 = float(input())
y4 = float(input())
p1 = (x1, y1)
p2 = (x2, y2)
p3 = (x3, y3)
p4 = (x4, y4)
line1 = (p1, p2)
line2 = (p3, p4)

longer_line = compare_lines(line1, line2)
print(format_coordinates(longer_line))
