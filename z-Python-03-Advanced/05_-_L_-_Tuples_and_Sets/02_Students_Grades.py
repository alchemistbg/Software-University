# 100/100

grades_count = int(input())

students = {}

for _ in range(grades_count):
    name, grade = input().split()
    grade = float(grade)

    if name not in students:
        students[name] = []

    students[name].append(grade)

for name, grades in students.items():
    grades = tuple(grades)
    avg = sum(grades) / len (grades)
    # print(f'{name} -> {" ".join("%.2f" % x for x in grades)} (avg: {avg:.2f})')
    print(f'{name} -> {" ".join([f"{grade:.2f}" for grade in grades])} (avg: {avg:.2f})')
