# 100/100

import sys

iterations = int(input())

minNumber = sys.maxsize
maxNumber = -sys.maxsize - 1

for i in range(1, iterations + 1):
    number = int(input())
    if number < minNumber:
        minNumber = number

    if number > maxNumber:
        maxNumber = number

print(f"Max number: {maxNumber}")
print(f"Min number: {minNumber}")
