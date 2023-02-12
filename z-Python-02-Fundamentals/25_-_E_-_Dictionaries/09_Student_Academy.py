# 100/100

students = {}

counter = int(input())

for _ in range(counter):
    student = input()
    grade = float(input())

    if not students.get(student):
        students[student] = []

    students[student].append(grade)

# for student in students.keys():
#     average_grade = sum(students[student]) / len(students[student])
#     if average_grade >= 4.5:
#         print(f'{student} -> {average_grade:.2f}')

# Solution with sorting
sorted_students = dict(sorted(students.items(), key = lambda kvp: -sum(kvp[1])/len(kvp[1])))
for student in sorted_students.keys():
    average_grade = sum(sorted_students[student]) / len(sorted_students[student])
    if average_grade >= 4.5:
        print(f'{student} -> {average_grade:.2f}')

# The lector uses second dictionary with student names and average grades and then sorts it to get the final result.
# He also uses so,me, dict comprehension.


