# 100/100

pensNumber = int(input())
markersNumber = int(input())
cleanerLitres = int(input())
discount = int(input()) / 100
totalSum = pensNumber * 5.8 + markersNumber * 7.20 + cleanerLitres * 1.2
finalSum = totalSum - (totalSum * discount)
print(finalSum)
