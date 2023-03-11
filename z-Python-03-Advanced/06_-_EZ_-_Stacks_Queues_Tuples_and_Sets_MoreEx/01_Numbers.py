# 100/100

def add_elements(s, elements):
    s.update(elements)
    return s


def remove_elements(s, elements):
    for el in elements:
        if el in s:
            s.remove(el)
    return s


set_1 = set(map(int, input().split()))
set_2 = set(map(int, input().split()))

counter = int(input())

for _ in range (counter):
    command_tokens = input().split(maxsplit = 2)
    if len(command_tokens) == 2:
        is_subset_1 = set_1.issubset(set_2)
        is_subset_2 = set_2.issubset(set_1)
        if is_subset_1 or is_subset_2:
            print(True)
            continue

        print(False)
        continue

    op_name = command_tokens[0]
    set_name = command_tokens[1]
    numbers = list(map(int, command_tokens[2].split()))

    if op_name == 'Add' and set_name == 'First':
        set_1 = add_elements(set_1, numbers)
    elif op_name == 'Add' and set_name == 'Second':
        set_2 = add_elements(set_2, numbers)
    elif op_name == 'Remove' and set_name == 'First':
        set_1 = remove_elements(set_1, numbers)
    elif op_name == 'Remove' and set_name == 'Second':
        set_2 = remove_elements(set_2, numbers)

set_1 = sorted(set_1)
set_2 = sorted(set_2)
print(', '.join(map(str, set_1)))
print(', '.join(map(str, set_2)))