# 100/100

students = int(input())
course_lectures = int(input())
initial_bonus = int(input())

max_student_bonus = 0
max_student_attendances = 0

current_student = 1

while current_student <= students:
    current_student_attendances = int(input())
    current_student_bonus = current_student_attendances / course_lectures * (5 + initial_bonus)

    if current_student_bonus > max_student_bonus:
        max_student_bonus = current_student_bonus
        max_student_attendances = current_student_attendances

    current_student += 1


print(f'Max Bonus: {round(max_student_bonus)}.')
print(f'The student has attended {max_student_attendances} lectures.')
