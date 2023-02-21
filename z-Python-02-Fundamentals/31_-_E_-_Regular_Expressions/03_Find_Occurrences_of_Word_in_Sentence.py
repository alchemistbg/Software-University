# 100/100

import re

test_string = input()
word = input()
pattern = fr'\b{word}\b'
matches = re.findall(pattern, test_string, re.IGNORECASE)
print(len(matches))
