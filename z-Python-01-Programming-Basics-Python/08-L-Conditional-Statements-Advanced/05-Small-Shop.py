# 100/100

product = input()
city = input()
qty = float(input())

price = 0
if city == "Sofia":
    if product == "coffee":
        price = qty * 0.50
    elif product == "water":
        price = qty * 0.80
    elif product == "beer":
        price = qty * 1.2
    elif product == "sweets":
        price = qty * 1.45
    elif product == "peanuts":
        price = qty * 1.6
elif city == "Plovdiv":
    if product == "coffee":
        price = qty * 0.40
    elif product == "water":
        price = qty * 0.70
    elif product == "beer":
        price = qty * 1.15
    elif product == "sweets":
        price = qty * 1.3
    elif product == "peanuts":
        price = qty * 1.5
elif city == "Varna":
    if product == "coffee":
        price = qty * 0.45
    elif product == "water":
        price = qty * 0.70
    elif product == "beer":
        price = qty * 1.1
    elif product == "sweets":
        price = qty * 1.35
    elif product == "peanuts":
        price = qty * 1.55
print(price)
