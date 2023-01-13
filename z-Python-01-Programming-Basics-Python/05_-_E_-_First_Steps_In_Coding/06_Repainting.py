# 100/100

plastic = int(input())
paint = int(input())
solvent = int(input())
hours = int(input())
plasticCost = (plastic + 2) * 1.5
paintCost = paint * 1.1 * 14.5
solventCost = solvent * 5
totalCost = plasticCost + paintCost + solventCost + 0.4
hourCost = 0.3 * totalCost * hours
print(totalCost + hourCost)
