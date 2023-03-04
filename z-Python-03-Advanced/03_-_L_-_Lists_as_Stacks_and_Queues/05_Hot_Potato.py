# 100/100

from collections import deque

kids = deque(input().split())
idx = int(input())

counter = 1
while len(kids) > 1:
    # kid = kids.popleft()
    #
    # if counter == idx:
    #     print(f'Removed {kid}')
    #     counter = 0
    # else:
    #     kids.append(kid)
    #
    # counter += 1

    # This is a lector's solution. I also had similar idea, but couldn't do it right.
    # Counter variable above is not necessary.
    kids.rotate(-idx)
    kid = kids.pop()
    print(f'Removed {kid}')

last_kid = kids.popleft()
print(f'Last is {last_kid}')
