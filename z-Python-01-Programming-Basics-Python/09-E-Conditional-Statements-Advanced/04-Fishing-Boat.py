# 100/100

budget = int(input())
season = input()
fishers = int(input())

rent = 0
baseDiscount = 0
countDiscount = 0
totalCost = 0

if season == "Spring":
    rent = 3000
elif season == "Winter":
    rent = 2600
else:
    rent = 4200

if fishers < 7:
    baseDiscount = rent * 0.1
elif fishers > 6 and fishers < 12:
    baseDiscount = rent * 0.15
else:
    baseDiscount = rent * 0.25

totalCost = rent - baseDiscount

if (fishers % 2 == 0) and season != "Autumn":
    countDiscount = totalCost * 0.05

totalCost -= countDiscount

leftover = budget - totalCost

if leftover >= 0:
    print(f"Yes! You have {leftover:.2f} leva left.")
else:
    print(f"Not enough money! You need {(leftover * -1):.2f} leva.")
