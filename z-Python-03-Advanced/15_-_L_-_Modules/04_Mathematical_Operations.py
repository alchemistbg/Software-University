# I cannot test this solution, because the problem doesn't exist in the judge system

from math_ops import parser, executor

expr = input()
result = executor.exec(*parser.parse(expr))
print(f'{result:.2f}')
