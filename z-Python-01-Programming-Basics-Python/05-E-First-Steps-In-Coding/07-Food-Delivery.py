# 100/100

chickenMenu = int(input())
fishMenu = int(input())
veganMenu = int(input())

chickenCost = chickenMenu * 10.35
fishCost = fishMenu * 12.40
veganCost = veganMenu * 8.15

menuCost = chickenCost + fishCost + veganCost
desertCost = menuCost * 0.2
deliveryCost = 2.5

totalCost = menuCost + desertCost + deliveryCost
print(totalCost)
