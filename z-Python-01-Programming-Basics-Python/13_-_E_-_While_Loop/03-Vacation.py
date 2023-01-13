# 100/100

moneyNeeded = float(input())
moneyInStock = float(input())

spendingDaysCounter = 0
totalDaysCounter = 0

while moneyInStock < moneyNeeded:
    action = input()
    money = float(input())
    totalDaysCounter += 1

    if action == "spend":
        moneyInStock -= money
        if moneyInStock < 0:
            moneyInStock = 0
        spendingDaysCounter += 1
        if spendingDaysCounter >= 5:
            print("You can't save the money.")
            print(f"{totalDaysCounter}")
            break
    else:
        moneyInStock += money
        spendingDaysCounter = 0
else:
    print(f"You saved the money for {totalDaysCounter} days.")
