# 100/100
# This solution looks very messy. It could be refactored

strings = input().split()

while True:
    command = input()

    if command == '3:1':
        break

    tokens =  command.split()
    name = tokens[0]
    first_param = int(tokens[1])
    second_param = int(tokens[2])

    if name == 'merge':
        if first_param < 0:
            first_param = 0
        strings_max_idx = len(strings) - 1
        if second_param > strings_max_idx:
            second_param = strings_max_idx

        merged = ''.join(strings[first_param: second_param + 1])
        leftovers = [s for idx, s in enumerate(strings) if idx < first_param or idx > second_param]
        leftovers.insert(first_param, merged)
        strings = leftovers[:]

    if name == 'divide':
        target_string = strings.pop(first_param)
        target_string_length = len(target_string)

        step = target_string_length // second_param
        target_string_list = [target_string[idx:idx + step] for idx in range(0, target_string_length, step)]

        if target_string_length % second_param != 0:
            target_last = target_string_list.pop()
            target_string_list[-1] += target_last

        strings[first_param:first_param] = target_string_list

print(' '.join(strings))
