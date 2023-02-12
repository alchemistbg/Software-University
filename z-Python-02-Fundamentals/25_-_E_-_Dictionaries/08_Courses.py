# 100/100

courses = {}

while True:
    data = input()
    if data == 'end':
        break

    course, name = data.split(' : ')
    if not courses.get(course):
        courses[course] = []

    courses[course].append(name)

# This is a solution without sorting
for course in courses:
    print(f'{course}: {len(courses[course])}')
    [print(f'-- {name}') for name in courses[course]]

# This solution is with sorting which is not needed. I did it for sake of exercise.
# It gives 20/100 because of the unnecessary sorting!
# sorted_courses = dict(sorted(courses.items(), key = lambda kvp: -len(kvp[1])))
# for course, students in sorted_courses.items():
#     print(f'{course}: {len(students)}')
#
#     sorted_students = sorted(students, key = lambda student: student)
#     for student in students:
#         print(f'-- {student}')
