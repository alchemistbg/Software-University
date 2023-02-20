import re

# pattern = r"(\+359-2-\d{3}-\d{4}|\+359 2 \d{3} \d{4})\b"
# test_string = input()
# matches = re.findall(pattern, test_string)
# print(', '.join(matches))

pattern = r"(\+359([ -])2\2\d{3}\2\d{4})\b"
test_string = input()
matches = re.findall(pattern, test_string)
result = []
for match in matches:
    result.append(match[0])

print(', '.join(result))
