# 100/100

iterations = int(input())

leftSum = 0
rightSum = 0
diff = 0

for i in range(1, (iterations * 2) + 1):
    number = int(input())
    if i <= iterations:
        leftSum += number
    else:
        rightSum += number

diff = leftSum - rightSum
if diff == 0:
    print(f"Yes, sum = {leftSum}")
else:
    print(f"No, diff = {abs(diff)}")
