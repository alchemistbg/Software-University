import re

# This doesn't catch all possible cases. There is a better regex in the problem description.
pattern  = r'((^|(?<=\s))(-*)(\d+)((\.\d+)?)($|(?=\s)))'
test_string = input()
matches = re.finditer(pattern, test_string)
for match in matches:
    print(match[1], end = ' ')
