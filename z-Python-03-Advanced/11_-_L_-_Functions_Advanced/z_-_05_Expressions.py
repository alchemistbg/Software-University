# This is lector's solutions - it is shorter because of chain class from itertools
# This solution however is slow. If product class is used, then the code runs faster
# from itertools import permutations, chain
#
# numbers = input().split(", ")
# n = len(numbers)
# operator_string = '+' * n + '-' * n
# operator_permutations = sorted(set(permutations(operator_string, n)))
# print(operator_permutations)
#
# for operator_permutation in operator_permutations:
#     zipped = list(zip(operator_permutation, numbers))
#     expression = ''.join(chain(*zipped))
#     expression_result = eval(expression)
#     print(f"{expression}={expression_result}")

# Solution with product from itertools
from itertools import product, chain

numbers = input().split(', ')
n = len(numbers)
operator_permutations = product('+-', repeat = n)

for operator_permutation in operator_permutations:
    zipped = list(zip(operator_permutation, numbers))
    expression = ''.join(chain(*zipped))
    expression_result = eval(expression)
    print(f"{expression}={expression_result}")


# This is my solution, written in prima vista
# from itertools import permutations
#
# numbers = input().split(", ")
# n = len(numbers)
# operator_string = '+' * n + '-' * n
# operator_permutations = sorted(set(permutations(operator_string, n)))
#
# expressions = []
# for operator_combination in operator_permutations:
#     raw_expression = zip(operator_combination, numbers)
#     flat_expression = []
#     for raw_tuple in raw_expression:
#         flat_expression.extend([*raw_tuple])
#     expressions.append(''.join(flat_expression))
#
# for expression in expressions:
#     print(f'{expression}={eval(expression)}')
