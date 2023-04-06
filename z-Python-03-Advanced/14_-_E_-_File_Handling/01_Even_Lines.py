# These problems have no tests in the judge system. The solution gives identical results like the tests from
# the description file

import re

pattern = r"[-,\.!?]"
substitution = "@"

with open('01_Even_Lines.txt') as f:
    lines = f.readlines()
    for idx in range(0, len(lines), 2):
        line = lines[idx].strip()
        line = re.sub(pattern, substitution, line)
        reversed_line = line.split()
        reversed_line.reverse()
        result = " ".join(reversed_line)
        print(result)
