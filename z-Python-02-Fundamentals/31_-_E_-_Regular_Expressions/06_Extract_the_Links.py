# 100/100

import re

pattern = r'www\.[A-Za-z0-9\-]+(\.[a-z]+)+'
valid_links = []

while True:
    line = input()
    if not line:
        break

    match = re.search(pattern, line)
    if match:
        print(match[0])
