# def multiply(*args):
#     result = 1
#     for arg in args:
#         result *= arg
#     return result
#
#
# numbers = list(map(int, input().split(', ')))
# multiplication = multiply(numbers)
# print(multiplication)

from functools import reduce


def multiply(*args):
    result = reduce(lambda a, b: a * b, args, 1)
    return result


test = multiply(1, 3, 5)
print(test)