# 100/100

counter = int(input())
query = input()

full_list = []
matches_list = []

while counter > 0:
    line = input()
    full_list.append(line)
    if query in line:
        matches_list.append(line)
    counter -= 1

print(full_list)
print(matches_list)
