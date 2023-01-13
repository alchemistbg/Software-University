# 100/100

iterations = int(input())

oddSum = 0
evenSum = 0

for i in range (1, iterations + 1):
    number = int(input())
    if i % 2 != 0:
        oddSum += number
    else:
        evenSum += number

diff = abs(oddSum - evenSum)

if diff == 0:
    print("Yes")
    print(f"Sum = {oddSum}")
else:
    print("No")
    print(f"Diff = {diff}")
