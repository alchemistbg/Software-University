# 100/100

n1 = int(input())
n2 = int(input())
n = int(input())

combinationCounter = 0

for i in range(n1, n2 + 1):
    for j in range(n1, n2 + 1):
        combinationCounter += 1
        if i + j == n:
            print(f"Combination N:{combinationCounter} ({i} + {j} = {n})")
            break
    else:
        continue
    break
else:
    print(f"{combinationCounter} combinations - neither equals {n}")
