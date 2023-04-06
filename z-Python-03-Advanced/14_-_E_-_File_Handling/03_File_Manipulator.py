# These problems have no tests in the judge system. The solution gives identical results like the tests from
# the description file

import os
import re

while True:
    command = input()
    if command == "End":
        break

    options = command.split('-')
    if options[0] == 'Create':
        with open(options[1], 'w') as f:
            pass
    elif options[0] == 'Add':
        with open(options[1], 'a') as f:
            f.write(f'{options[2]}\n')
    elif options[0] == 'Replace':
        try:
            with open(options[1], 'r') as f:
                text = f.read()
                text = re.sub(options[2], options[3], text)
            with open(options[1], 'w') as f:
                f.write(text)
        except FileNotFoundError:
            print('An error occurred')
    elif options[0] == 'Delete':
        try:
            os.remove(options[1])
        except FileNotFoundError:
            print('An error occurred')
