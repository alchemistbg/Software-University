# 100/100

counter = int(input())

names = set()
for _ in range(counter):
    name = input()
    names.add(name)

print("\n".join(names))