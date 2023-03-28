from itertools import combinations

names = input().split(', ')
chairs_count = int(input())
chairs = list(combinations(names, chairs_count))
for chair in chairs:
    print(', '.join(chair))