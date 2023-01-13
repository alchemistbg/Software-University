# 100/100

budget = float(input())
gpuCount = int(input())
cpuCount = int(input())
ramCount = int(input())

gpuCost = gpuCount * 250
cpuCost = gpuCost * 0.35 * cpuCount
ramCost = gpuCost * 0.10 * ramCount

totalCost = gpuCost + cpuCost + ramCost
if gpuCount > cpuCount:
    totalCost -= totalCost * 0.15

if budget >= totalCost:
    leftover = budget - totalCost
    print(f"You have {leftover:.2f} leva left!")
else:
    leftover = totalCost - budget
    print(f"Not enough money! You need {leftover:.2f} leva more!")
