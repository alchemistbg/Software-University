# 100/100

counter = int(input())

periodic_table = set()

for _ in range(counter):
    elements = input().split()
    periodic_table.update(elements)

print('\n'.join(periodic_table))
