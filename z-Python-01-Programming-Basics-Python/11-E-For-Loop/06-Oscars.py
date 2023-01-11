# 100/100

actorName = input()
initialPoints = float(input())
judgesCount = int(input())

totalPoints = initialPoints
for i in range(0, judgesCount):
    judgeName = input()
    judgePoints = float(input())
    currentPoints = len(judgeName) * judgePoints / 2
    totalPoints += currentPoints

    if totalPoints >= 1250.5:
        print(f"Congratulations, {actorName} got a nominee for leading role with {totalPoints:.1f}!")
        break
else:
    print(f"Sorry, {actorName} you need {1250.5 - totalPoints:.1f} more!")
