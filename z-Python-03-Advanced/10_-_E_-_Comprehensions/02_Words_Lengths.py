# I cannot test this solution, because the problem is removed from the judge system

# words = input().split(', ')
# print(', '.join([f'{word} -> {len(word)}' for word in words]))

# One line solution
[print(f'{word} -> {len(word)}') for word in input().split(', ')]