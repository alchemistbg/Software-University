# 100/100

import sys

numbers = [int(s) for s in input().split()]

command = input()

while command != 'end':
    if 'exchange' in command:
        temp = []
        idx = int(command.split()[1])

        if 0 > idx or idx > len(numbers) - 1:
            print('Invalid index')
            command = input()
            continue

        split_index = idx + 1

        temp.extend(numbers[split_index : ])
        temp.extend(numbers[0 : split_index])
        numbers = temp[:]

    if 'max even' == command:
        max_idx = -1
        max_value = -sys.maxsize

        for idx in range(len(numbers)):
            if numbers[idx] >= max_value and numbers[idx] % 2 == 0:
                max_value = numbers[idx]
                max_idx = idx

        if max_idx == -1:
            print('No matches')
        else:
            print(max_idx)

    if 'min even' == command:
        min_idx = -1
        min_value = sys.maxsize

        for idx in range(len(numbers)):
            if numbers[idx] <= min_value and numbers[idx] % 2 == 0:
                min_value = numbers[idx]
                min_idx = idx

        if min_idx == -1:
            print('No matches')
        else:
            print(min_idx)

    if 'max odd' == command:
        max_idx = -1
        max_value = -sys.maxsize

        for idx in range(len(numbers)):
            if numbers[idx] >= max_value and numbers[idx] % 2 != 0:
                max_value = numbers[idx]
                max_idx = idx

        if max_idx == -1:
            print('No matches')
        else:
            print(max_idx)

    if 'min odd' == command:
        min_idx = -1
        min_value = sys.maxsize

        for idx in range(len(numbers)):
            if numbers[idx] <= min_value and numbers[idx] % 2 != 0:
                min_value = numbers[idx]
                min_idx = idx

        if min_idx == -1:
            print('No matches')
        else:
            print(min_idx)

    if len(command.split()) == 3:
        side, count, num_type = command.split()
        count = int(count)

        filtered = []

        if count > len(numbers):
            print('Invalid count')
            command = input()
            continue

        if side == 'first' and num_type == 'even':
            filtered = list(filter(lambda x: x % 2 == 0, numbers))[0:count]

        if side == 'first' and num_type == 'odd':
            filtered = list(filter(lambda x: x % 2 != 0, numbers))[0:count]

        if side == 'last' and num_type == 'even':
            filtered = list(filter(lambda x: x % 2 == 0, numbers))
            rev_count = len(filtered) - count
            if count < len(filtered):
                filtered = filtered[rev_count:]

        if side == 'last' and num_type == 'odd':
            filtered = list(filter(lambda x: x % 2 != 0, numbers))
            rev_count = len(filtered) - count
            if count < len(filtered):
                filtered = filtered[rev_count:]

        print(filtered)

    command = input()

print(numbers)
