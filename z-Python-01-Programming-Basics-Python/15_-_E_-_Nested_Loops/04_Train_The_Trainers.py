# 100/100

judgesNumber = int(input())
totalGrade = 0
counter = 0

text = input()
while text != "Finish":
    title = text
    grade = 0
    for i in range(judgesNumber):
        grade += float(input())

    grade = grade / judgesNumber

    totalGrade += grade
    print(f"{title} - {grade:.2f}.")
    counter += 1
    text = input()

totalGrade = totalGrade / counter
print(f"Student's final assessment is {totalGrade:.2f}.")
