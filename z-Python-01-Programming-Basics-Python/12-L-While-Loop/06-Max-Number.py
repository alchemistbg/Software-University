# 100/100

import sys

text = input()

maxNumber = -sys.maxsize
while text != "Stop":
    if int(text) > maxNumber:
        maxNumber = int(text)
    text = input()

print(maxNumber)
