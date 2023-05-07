# 100/100

from functools import reduce
import operator

class Calculator:

    @staticmethod
    def add(*args):
        # result = reduce(lambda a, b: a + b, args)
        result = reduce(operator.add, args)
        return result

    @staticmethod
    def multiply(*args):
        # result = reduce(lambda a, b: a * b, args)
        result = reduce(operator.mul, args)
        return result

    @staticmethod
    def divide(*args):
        # result = reduce(lambda a, b: a / b, args)
        result = reduce(operator.truediv, args)
        return result

    @staticmethod
    def subtract(*args):
        # result = reduce(lambda a, b: a - b, args)
        result = reduce(operator.sub, args)
        return result


print(Calculator.add(5, 10, 4))
print(Calculator.multiply(1, 2, 3, 5))
print(Calculator.divide(100, 2))
print(Calculator.subtract(90, 20, -50, 43, 7))
