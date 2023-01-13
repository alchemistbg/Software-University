# 100/100

toursCount = int(input())
initialPoints = int(input())

toursWins = 0
totalPoints = initialPoints
for i in range(0, toursCount):
    result = input()

    if result == "W":
        toursWins += 1
        totalPoints += 2000
    elif result == "F":
        totalPoints += 1200
    else:
        totalPoints += 720

averagePoints = (totalPoints - initialPoints) // toursCount
toursWinsPercents = toursWins / toursCount * 100
print(f"Final points: {totalPoints}")
print(f"Average points: {averagePoints}")
print(f"{toursWinsPercents:.2f}%")
