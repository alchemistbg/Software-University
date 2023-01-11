# 100/100

import sys

iterations = int(input())

maxElement = - sys.maxsize
elementsSum = 0
diff = 0

for i in range(0, iterations):
    number = int(input())
    elementsSum += number

    if number > maxElement:
        maxElement = number

if maxElement == elementsSum - maxElement:
    print("Yes")
    print(f"Sum = {maxElement}")
else:
    smallerSum = elementsSum - maxElement
    diff = abs(smallerSum - maxElement)
    print("No")
    print(f"Diff = {diff}")
