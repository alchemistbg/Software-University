# 100/100

import math

number = int(input())

for i in range(2, int(math.sqrt(number)) + 1):
    mod_division = number % i
    if mod_division == 0:
        print(False)
        break
else:
    print(True)
