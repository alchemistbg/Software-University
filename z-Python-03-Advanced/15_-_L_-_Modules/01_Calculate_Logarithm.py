# I cannot test this solution, because the problem doesn't exist in the judge system

import math

number = int(input())
base = input()

if base == 'natural':
    result = math.log(number)
else:
    base = int(base)
    result = math.log(number, base)

print(f'{result:.2f}')