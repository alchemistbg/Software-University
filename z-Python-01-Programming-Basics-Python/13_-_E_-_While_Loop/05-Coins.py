# 100/100

change = float(input())

coinsCounter = 0

while change > 0:
    if change - 2 >= 0:
        change -= 2
        coinsCounter += 1
    elif change - 1 >= 0:
        change -= 1
        coinsCounter += 1
    elif change - 0.5 >= 0:
        change -= 0.5
        coinsCounter += 1
    elif change - 0.2 >= 0:
        change -= 0.2
        coinsCounter += 1
    elif change - 0.1 >= 0:
        change -= 0.1
        coinsCounter += 1
    elif change - 0.05 >= 0:
        change -= 0.05
        coinsCounter += 1
    elif change - 0.02 >= 0:
        change -= 0.02
        coinsCounter += 1
    elif change - 0.01 >= 0:
        change -= 0.01
        coinsCounter += 1

    change = round(change, 2)
print(coinsCounter)
