# 100/100

import re

result = []
pattern = r'\b_([A-Za-z0-9]+)\b'
test_string = input()
matches = re.findall(pattern, test_string)
for match in matches:
    result.append(match)

print(','.join(result))
