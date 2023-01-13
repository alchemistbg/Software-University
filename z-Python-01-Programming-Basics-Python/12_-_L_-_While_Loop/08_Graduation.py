# 100/100

name = input()

classCount = 1
failsCount = 0

totalGrade = 0

while classCount <= 12:
    currGrade = float(input())

    if currGrade >= 4.00:
        totalGrade += currGrade
        classCount += 1
    else:
        failsCount += 1
        if failsCount > 1:
            print(f"{name} has been excluded at {classCount} grade")
            break
else:
    avgGrade = totalGrade / 12
    print(f"{name} graduated. Average grade: {avgGrade:.2f}")
