# 100/100

flowerType = input()
flowerCount = int(input())
budget = int(input())

flowerCost = 0
flowerDiscount = 0
flowerOverPrice = 0

if flowerType == "Roses":
    flowerCost = flowerCount * 5
    if flowerCount > 80:
        flowerDiscount = flowerCost * 0.1
        flowerOverPrice = 0
elif flowerType == "Dahlias":
    flowerCost = flowerCount * 3.8
    if flowerCount > 90:
        flowerDiscount = flowerCost * 0.15
        flowerOverPrice = 0
elif flowerType == "Tulips":
    flowerCost = flowerCount * 2.8
    if flowerCount > 80:
        flowerDiscount = flowerCost * 0.15
        flowerOverPrice = 0
elif flowerType == "Narcissus":
    flowerCost = flowerCount * 3
    if flowerCount < 120:
        flowerDiscount = 0
        flowerOverPrice = flowerCost * 0.15
elif flowerType == "Gladiolus":
    flowerCost = flowerCount * 2.5
    if flowerCount < 80:
        flowerDiscount = 0
        flowerOverPrice = flowerCost * 0.2

finalCost = flowerCost - flowerDiscount + flowerOverPrice

leftover = budget - finalCost

if leftover >= 0:
    print(f"Hey, you have a great garden with {flowerCount} {flowerType} and {leftover:.2f} leva left.")
else:
    print(f"Not enough money, you need {(leftover * -1):.2f} leva more.")
