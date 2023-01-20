# 100/100

# List comprehension (I am still not comfortable with it)
numbers_list = [int(s) for s in input().split(', ')]
beggars_count = int(input())

beggars_sums = list([0] * beggars_count)

for beggar in range(beggars_count):
    for idx in range(beggar, len(numbers_list), beggars_count):
        beggars_sums[beggar] += numbers_list[idx]

print(beggars_sums)

# This solution is based on the following code:
# https://softuni.bg/forum/34229/number-beggars-fundamentals-py#answer-64112
# It is very interesting and uses just one for loop.
# numbers_list = [int(s) for s in input().split(', ')]
# beggars_count = int(input())
#
# beggars_sums = list([0] * beggars_count)
# counter = 0
#
# for number in numbers_list:
#     beggars_sums[counter] += number
#     counter += 1
#     if counter >= beggars_count:
#         counter = 0
#
# print(beggars_sums)
