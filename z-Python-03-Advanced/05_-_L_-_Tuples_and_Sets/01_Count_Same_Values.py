# 100/100

result = {}
elements = tuple(map(float, input().split()))

# Variant 1
# for elem in elements:
#     if elem not in result.keys():
#         result[elem] = 0
#
#     result[elem] += 1
#

# Variant 2
for elem in elements:
    if elem not in result.keys():
        result[elem] = elements.count(elem)
    else:
        continue

for number, freq in result.items():
    print(f'{number} - {freq} times')
