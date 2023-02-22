# 100/100

import re

letters = r'[A-Za-z]'
numbers = r'\d'

names = input().split(', ')
race_scores = {}
for name in names:
    race_scores[name] = 0

while True:
    line = input()
    if line == 'end of race':
        break

    racer_matches = re.findall(letters, line)
    racer = ''.join(racer_matches)

    score_matches = re.findall(numbers, line)
    score = 0
    for score_match in score_matches:
        score += int(score_match)

    if racer in names:
        race_scores[racer] += score

prefixes = ['1st', '2nd', '3rd']
sorted_race_scores = sorted(race_scores.items(), key = lambda kvp: -kvp[1])
for i in range(0, 3):
    print(f'{prefixes[i]} place: {sorted_race_scores[i][0]}')