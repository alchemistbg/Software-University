# 100/100

counter = int(input())

usernames = set()

for _ in range(counter):
    name = input()
    usernames.add(name)

print('\n'.join(usernames))
