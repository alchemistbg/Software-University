# 100/100

iterations = int(input())

p1 = 0
p2 = 0
p3 = 0
p4 = 0
p5 = 0

for i in range(0, iterations):
    num = int(input())
    if num < 200:
        p1 += 1 / iterations * 100
    elif num >= 200 and num < 400:
        p2 += 1 / iterations * 100
    elif num >= 400 and num < 600:
        p3 += 1 / iterations * 100
    elif num >= 600 and num < 800:
        p4 += 1 / iterations * 100
    else:
        p5 += 1 / iterations * 100

print(f"{p1:.2f}%\n{p2:.2f}%\n{p3:.2f}%\n{p4:.2f}%\n{p5:.2f}%")
