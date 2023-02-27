# 100/100

import re

locations = []
travel_points = 0

pattern = r'(=|/)(?P<location>[A-Z][A-Za-z]{2,})(\1)'

text = input()
matches = re.finditer(pattern, text, re.MULTILINE)
for match in matches:
    location = match.group('location')
    locations.append(location)
    travel_points += len(location)

print(f'Destinations: {", ".join(locations)}')
print(f'Travel Points: {travel_points}')
