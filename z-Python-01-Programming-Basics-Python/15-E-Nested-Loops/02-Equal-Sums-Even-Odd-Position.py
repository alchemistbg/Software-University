# 100/100

n1 = int(input())
n2 = int(input())

sumEven = 0
sumOdd= 0

for n in range(n1, n2 + 1):
    s = str(n)
    for i in range(6):
        if i % 2 == 0:
            sumEven += int(s[i])
        else:
            sumOdd += int(s[i])
    if sumEven == sumOdd:
        print(s, end = ' ')
    sumEven = 0
    sumOdd = 0
