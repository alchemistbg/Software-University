# 100/100

e1 = int(input())
e2 = int(input())
e3 = int(input())

students = int(input())
hours = 0

while students > 0:
    hour_students = e1 + e2 + e3
    students -= hour_students

    hours += 1

    if hours % 4 == 0:
        hours += 1

print(f'Time needed: {hours}h.')
