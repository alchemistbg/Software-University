# 100/100

import math;

figureType = input()
area = 0.0
if figureType == "square":
    side = float(input())
    area = side * side
elif figureType == "rectangle":
    a = float(input())
    b = float(input())
    area = a * b
elif figureType == "circle":
    r = float(input())
    area = r * r * math.pi
elif figureType == "triangle":
    a = float(input())
    h = float(input())
    area = a * h / 2

print(f"{area:.3f}")
