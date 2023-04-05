# These problems have no tests in the judge system. The solution gives identical results like the tests from
# the description file

import re

with open('05_Word_Count_WORDS.txt') as f_words:
    words = f_words.read().split()

with open('05_Word_Count_TEXT.txt') as f:
    text = f.read().lower()

result = {}
for word in words:
    regex_pattern = rf'\b{word}\b'
    matches = re.findall(regex_pattern, text, re.MULTILINE)
    # if word not in result.keys():
    #     result[word] = 0
    result[word] = len(matches)

sorted_result = dict(sorted(result.items(), key = lambda kvp: -kvp[1]))
with open('05_Word_Count_OUTPUT.txt', 'w') as f:
    for word_text, word_occurrences in sorted_result.items():
        row = f'{word_text} - {word_occurrences}\n'
        f.write(row)
