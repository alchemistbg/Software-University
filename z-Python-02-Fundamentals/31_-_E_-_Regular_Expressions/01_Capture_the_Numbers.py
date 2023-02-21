# 100/100

import re

pattern = r'\d+'
result = []
while True:
    test_string = input()
    if not test_string:
        break

    matches = re.findall(pattern, test_string)
    if matches:
        result.extend(matches)

print(' '.join(result))
