# 100/100

raw = input().split('|')
lists = [raw[i].split() for i in range(len(raw) - 1, -1, -1)]
flat_lists = [elem for list in lists for elem in list]
print(' '.join(map(str, flat_lists)))
