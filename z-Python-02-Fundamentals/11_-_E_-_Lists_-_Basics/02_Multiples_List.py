# 100/100

# This solution is faster (according the softuni's judge metrics)
factor = int(input())
size = int(input())

numbers = list([factor] * size)

for idx in range(1, len(numbers)):
    numbers[idx] = numbers[idx - 1] + factor

print(numbers)

# factor = int(input())
# list_size = int(input())
#
# numbers_list = []
#
# for idx in range (1, list_size + 1):
#     number = idx * factor
#     numbers_list.append(number)
#     numbers_list
#
# print(numbers_list)
