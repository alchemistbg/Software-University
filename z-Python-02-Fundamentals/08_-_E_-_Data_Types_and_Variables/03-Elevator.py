# 100/100

# This solution uses vanilla python
persons = int(input())
capacity = int(input())

courses = persons // capacity
if persons % capacity != 0:
    courses += 1

# This solution uses math module
# import math
#
# persons = int(input())
# capacity = int(input())
#
# courses = math.ceil(persons / capacity)

print(courses)
