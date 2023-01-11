# 100/100

import sys

text = input()

minNumber = sys.maxsize

while text != "Stop":
    if int(text) < minNumber:
        minNumber = int(text)
    text = input()

print(minNumber)
