# These problems have no tests in the judge system. The solution gives identical results like the tests from
# the description file

import re
import string

chars_pattern = rf'[{string.ascii_letters}]'
non_chars_pattern = rf'[{string.punctuation}]'

output = []

with open('02_Line_Numbers_INPUT.txt') as f:
    lines = f.readlines()
    for idx, line in enumerate(lines):
        line = line.strip()

        chars = len(re.findall(chars_pattern, line))
        non_chars = len(re.findall(non_chars_pattern, line))

        line_final = f'Line {idx + 1}: {line} ({chars}) ({non_chars})'

        output.append(line_final)

with open('02_Line_Numbers_OUTPUT.txt', 'w') as f:
    output_final = '\n'.join(output)
    f.write(output_final)
