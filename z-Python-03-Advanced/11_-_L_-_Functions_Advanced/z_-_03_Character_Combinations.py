# combinations = set()
#
#
# def generate(k, A):
#     if k == 1:
#         combinations.add(''.join(A))
#     else:
#         generate(k - 1, A)
#
#         for i in range(k):
#             if k % 2 == 0:
#                 A[i], A[k-1] = A[k-1], A[i]
#             else:
#                 A[0], A[k-1] = A[k-1], A[0]
#             generate(k - 1, A)
#
#
# s = 'abc'
# generate(len(s), list(s))
# print('\n'.join(list(combinations)))


# The following solution is from the lecture
# def print_comb(text, idx):
#     if idx >= len(text):
#         print("".join(text))
#         return
#     print_comb(text, idx + 1)
#     for i in range(idx + 1, len(text)):
#         text[idx], text[i] = text[i], text[idx]
#         print_comb(text, idx + 1)
#         text[idx], text[i] = text[i], text[idx]
#
# text = list(input())
# print_comb(text, 0)


# This solution uses permutation class from itertools module
from itertools import permutations

perm = list(permutations('abc'))
for p in perm:
    print(''.join(p))
