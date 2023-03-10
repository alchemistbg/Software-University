# 100/100

counter = int(input())
longest_intersection = set()

for _ in range(counter):
    data_1, data_2 = input().split('-')

    range_1_start, range_1_end = map(int, data_1.split(','))
    range_2_start, range_2_end = map(int, data_2.split(','))

    range_1 = range(range_1_start, range_1_end + 1)
    range_2 = range(range_2_start, range_2_end + 1)

    set_1 = set(range_1)
    set_2 = set(range_2)

    intersection = set_1.intersection(set_2)

    if len(intersection) > len(longest_intersection):
        longest_intersection = intersection

print(f'Longest intersection is [{", ".join(map(str, longest_intersection))}] with length {len(longest_intersection)}')