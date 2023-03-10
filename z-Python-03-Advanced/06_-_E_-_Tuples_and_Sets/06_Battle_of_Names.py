# 100/100

counter = int(input())
odd = set()
even = set()

for count in range(counter):
    name = input()
    name_sum = 0
    for ch in name:
        name_sum += ord(ch)

    name_sum = name_sum // (1 + count)

    if name_sum % 2 == 0:
        even.add(name_sum)
    else:
        odd.add(name_sum)

odd_sum = sum(odd)
even_sum = sum(even)
if odd_sum > even_sum:
    diff = odd.difference(even)
    print(', '.join(map(str, diff)))
elif even_sum > odd_sum:
    sym_diff = odd.symmetric_difference(even)
    print(', '.join(map(str, sym_diff)))
else:
    union = odd.union(even)
    print(', '.join(map(str, union)))
