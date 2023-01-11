# 100/100

badGradesLimit = int(input())

badGradesCounter = 0
averageGrade = 0
sumOfGrades = 0
taskCounter = 0
lastTaskName = ""

while badGradesCounter < badGradesLimit:
    taskName = input()
    if taskName == "Enough":
        print(f"Average score: {averageGrade:.2f}")
        print(f"Number of problems: {taskCounter}")
        print(f"Last problem: {lastTaskName}")
        break
    taskGrade = int(input())
    taskCounter += 1
    sumOfGrades += taskGrade
    averageGrade = sumOfGrades / taskCounter
    lastTaskName = taskName
    if taskGrade <= 4:
        badGradesCounter += 1
else:
    print(f"You need a break, {badGradesLimit} poor grades.")
