# 100/100

import operator
from functools import reduce

def operate(op, *args):
    numbers = list(map(int, args))
    operations = {
        '+': operator.add,
        '-': operator.sub,
        '*': operator.mul,
        '/': operator.truediv,
    }
    result = reduce(operations[op], numbers)
    return result

print(operate("+", 1, 2, 3))
print(operate("*", 3, 4))
