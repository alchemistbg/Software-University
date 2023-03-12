from collections import deque

tokens = deque(input().split())

all_colors = ("red", "yellow", "blue", "orange", "purple", "green")
primary_colors = ("red", "yellow", "blue")
secondary_colors = ("orange", "purple", "green")
mixed_colors = {
    'orange': ('red', 'yellow'),
    'purple': ('red', 'blue'),
    'green': ('yellow', 'blue')
}

found_colors = []

while tokens:
    first_token = tokens.popleft()
    if len(tokens) > 0:
        last_token = tokens.pop()
    else:
        last_token = ''

    combined_1 = first_token + last_token
    combined_2 = last_token + first_token
    if combined_1 in all_colors:
        found_colors.append(combined_1)
    elif combined_2 in all_colors:
        found_colors.append(combined_2)
    else:
        first_token = first_token[:-1]
        last_token = last_token[:-1]
        idx = len(tokens) // 2

        if first_token:
            tokens.insert(idx, first_token)
        if last_token:
            tokens.insert(idx, last_token)

for color in found_colors:
    if color in secondary_colors:
        f_primary, s_primary = mixed_colors[color]
        if f_primary not in found_colors or s_primary not in found_colors:
            found_colors.remove(color)
print(found_colors)
