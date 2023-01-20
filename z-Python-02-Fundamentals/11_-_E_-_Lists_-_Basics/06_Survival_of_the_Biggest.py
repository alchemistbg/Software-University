# 100/100
# There are some solutions in the softuni forum that also give 100/100 points,
# but they use more resources in judge

numbers_list = [int(ch) for ch in input().split(' ')]
survivor = int(input())

start_idx = len(numbers_list) - survivor
numbers_to_remove_list = sorted(numbers_list, reverse = True)[start_idx:]

for number in numbers_to_remove_list:
    numbers_list.remove(number)

result = map(str, numbers_list)
print(", ".join(result))
