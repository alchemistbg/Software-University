# 100/100

import re

pattern = r'\b(?<![\.\-_])(([A-Za-z0-9]+)(([\.\-_])[A-Za-z0-9]+)*@[A-Za-z]+(([\-\.])[A-Za-z]+)*\.[A-Za-z]+)\b'
test_string = input()
matches = re.findall(pattern, test_string, re.IGNORECASE)
for match in matches:
    print(match[0])
