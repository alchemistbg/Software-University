# 100/100

divisor = int(input())
boundary = int(input())

while True:
    if boundary % divisor == 0:
        print(boundary)
        break
    else:
        boundary -= 1
