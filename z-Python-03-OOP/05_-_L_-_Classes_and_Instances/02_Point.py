# 100/100
import math


class Point:
    def __init__(self, x: int, y: int):
        self.x = x
        self.y = y

    def set_x(self, new_x: int):
        self.x = new_x

    def set_y(self, new_y: int):
        self.y = new_y

    def __str__(self) -> str:
        return f"The point has coordinates ({self.x},{self.y})"

    # This method is added based on the old version of the task
    def distance(self, x, y) -> float:
        diff_x = (self.x - x)**2
        diff_y = (self.y - y)**2
        return math.sqrt(diff_x + diff_y)


p = Point(2, 4)
print(p)
p.set_x(3)
p.set_y(5)
print(p)
print(p.distance(10, 2))
