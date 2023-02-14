# 100/100

contests = {}
total_points = {}

while True:
    data = input()
    if data == 'no more time':
        break
    username, contest, points = data.split(' -> ')
    points = int(points)

    # Initialize contests dictionary
    if not contests.get(contest):
        contests[contest] = {}

    # Initialize total_points dictionary
    if not total_points.get(username):
        total_points[username] = 0

    if not contests[contest].get(username):
        contests[contest][username] = 0

    if points > contests[contest][username]:
        total_points[username] -= contests[contest][username]
        total_points[username] += points
        contests[contest][username] = points

for contest in contests:
    print(f'{contest}: {len(contests[contest].keys())} participants')
    sorted_contest = dict(sorted(contests[contest].items(), key = lambda kvp: (-kvp[1], kvp[0])))
    for idx, participant in enumerate(sorted_contest):
        print(f'{idx + 1}. {participant} <::> {sorted_contest[participant]}')

sorted_total_points = dict(sorted(total_points.items(), key = lambda kvp: (-kvp[1], kvp[0])))
print('Individual standings:')
for idx, student in enumerate(sorted_total_points):
    print(f'{idx + 1}. {student} -> {sorted_total_points[student]}')
