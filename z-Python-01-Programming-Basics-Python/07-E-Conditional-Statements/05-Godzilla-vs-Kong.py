# 100/100

budget = float(input())
dummyArtists = int(input())
costumPrice = float(input())

movieSetsPrice = budget * 0.1

totalCostumPrice = dummyArtists * costumPrice
totalCostumPriceDiscount = 0
if dummyArtists >= 150:
    totalCostumPriceDiscount = totalCostumPrice * 0.1
totalCostumPrice -= totalCostumPriceDiscount

totalExpenditures = budget - totalCostumPrice - movieSetsPrice

if totalExpenditures >= 0:
    print("Action!")
    print(f"Wingard starts filming with {totalExpenditures:.2f} leva left.")
else:
    print("Not enough money!")
    print(f"Wingard needs {totalExpenditures * -1:.2f} leva more.")
