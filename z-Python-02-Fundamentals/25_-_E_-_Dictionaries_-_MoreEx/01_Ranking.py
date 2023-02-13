# 100/100
# This solution is very complicated. I don't like it! Maybe I will refactor it.

contests = {}

while True:
    data = input()
    if data == 'end of contests':
        break

    contest, password = data.split(':')
    contests[contest] = password

submissions = {}

while True:
    data = input()
    if data == 'end of submissions':
        break

    contest, password, username, points = data.split('=>')
    points = int(points)

    if contest in contests.keys() and password == contests[contest]:
        if not submissions.get(username):
            submissions[username] = []

        submission = {
            'course': contest,
            'points': points
        }

        old_submission = [old_contest for old_contest in submissions[username] if old_contest['course'] == contest]

        if not old_submission:
            submissions[username].append(submission)
        elif old_submission and old_submission[0]['points'] < points:
            old_submission[0]['points'] = points

students_by_points = {}
for student, course in submissions.items():
    students_by_points[student] = 0
    for submission in submissions[student]:
        students_by_points[student] += submission['points']

sorted_by_points = dict(sorted(students_by_points.items(), key = lambda x: x[1]))
best = sorted_by_points.popitem()
print(f'Best candidate is {best[0]} with total {best[1]} points.')

print('Ranking:')
sorted_submissions = dict(sorted(submissions.items()))
for student, courses in sorted_submissions.items():
    print(f'{student}')
    sorted_courses = sorted(courses, key = lambda x: -x['points'])
    for sorted_course in sorted_courses:
        print(f'#  {sorted_course["course"]} -> {sorted_course["points"]}')
