# 100/100

array = [int(n) for n in input().split()]
avrg = sum(array) / len(array)
filtered = [n for n in array if n > avrg]
filtered.sort(reverse = True)

if filtered:
    print(' '.join(map(str, filtered[:5])))
else:
    print('No')