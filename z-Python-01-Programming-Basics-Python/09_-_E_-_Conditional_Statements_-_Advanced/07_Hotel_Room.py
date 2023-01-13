# 100/100

month = input()
nights = int(input())

price1 = "May, October"
price2 = "June, September"
price3 = "July, August"

studioPrice = 0
flatPrice = 0

if month in price1:
    studioPrice = 50
    flatPrice = 65
elif month in price2:
    studioPrice = 75.2
    flatPrice = 68.70
elif month in price3:
    studioPrice = 76
    flatPrice = 77

totalStudioPrice = studioPrice * nights
totalFlatPrice = flatPrice * nights

studioDiscount = 0
flatDiscount = 0
if (nights > 7 and nights < 15) and month in price1:
    studioDiscount = totalStudioPrice * 0.05
elif nights > 14 and month in price1:
    studioDiscount = totalStudioPrice * 0.3
elif nights > 14 and month in price2:
    studioDiscount = totalStudioPrice * 0.2

if nights > 14:
    flatDiscount = totalFlatPrice * 0.1

finalStudioPrice = totalStudioPrice - studioDiscount
finalFlatPrice = totalFlatPrice - flatDiscount

print(f"Apartment: {finalFlatPrice:.2f} lv.")
print(f"Studio: {finalStudioPrice:.2f} lv.")
