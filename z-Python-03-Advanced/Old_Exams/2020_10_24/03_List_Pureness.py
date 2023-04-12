# 100/100

def best_list_pureness(test_list: list, rotations):
    purenesses = []
    for rotation in range(rotations + 1):
        pureness = 0

        if rotation > 0:
            end_elem = [test_list.pop()]
            test_list = end_elem + test_list

        for idx, value in enumerate(test_list):
            pureness += idx * value

        purenesses.append(pureness)

    max_pureness = max(purenesses)
    max_pureness_idx = purenesses.index(max_pureness)
    return f'Best pureness {max_pureness} after {max_pureness_idx} rotations'


test = ([4, 3, 2, 6], 4)
result = best_list_pureness(*test)
print(result)

test = ([7, 9, 2, 5, 3, 4], 3)
result = best_list_pureness(*test)
print(result)

test = ([1, 2, 3, 4, 5], 10)
result = best_list_pureness(*test)
print(result)
