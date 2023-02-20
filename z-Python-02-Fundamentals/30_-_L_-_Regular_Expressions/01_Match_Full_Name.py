import re

# pattern = r"\b([A-Z]{1}[a-z]{1,} [A-Z]{1}[a-z]{1,})\b"
pattern = r"\b([A-Z][a-z]+ [A-Z][a-z]+)\b"

test_string = input()

matches = re.findall(pattern, test_string, re.MULTILINE)

result = []

for idx, match in enumerate(matches):
    result.append(match)

print(' '.join(result))
