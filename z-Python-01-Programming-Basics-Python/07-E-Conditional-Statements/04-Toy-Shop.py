# 100/100

travelPrice = float(input())
jigsawsNumber = int(input())
dollsNumber = int(input())
teddiesNumber = int(input())
minionsNumber = int(input())
trucksNumber = int(input())

jigssawsPrice = jigsawsNumber * 2.6
dollsPrice = dollsNumber * 3
teddiesPrice = teddiesNumber * 4.1
minionsPrice = minionsNumber * 8.2
trucksPrice = trucksNumber * 2

totalToysNumber = jigsawsNumber + dollsNumber + teddiesNumber + minionsNumber + trucksNumber
totalToysPrice = jigssawsPrice + dollsPrice + teddiesPrice + minionsPrice + trucksPrice

if totalToysNumber >= 50:
    totalToysPrice -= totalToysPrice * 0.25

rent = totalToysPrice * 0.1

profit = totalToysPrice - rent

leftover = 0
leftover = profit - travelPrice
if profit >= travelPrice:
    print(f"Yes! {leftover:.2f} lv left.")
else:
    leftover *= -1
    print(f"Not enough money! {leftover:.2f} lv needed.")
