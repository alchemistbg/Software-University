# 100/100
# This solution is very big. Maybe it could be reduced!

gifts = input().split()

command_line = input()

result = []

while command_line != 'No Money':
    command_options = command_line.split()
    command_text = command_options[0]
    command_param = command_options[1]

    if command_text == 'OutOfStock':
        for idx, gift in enumerate(gifts):
            if gift == command_param:
                gifts[idx] = 'None'

    if command_text == 'Required':
        idx = int(command_options[2])
        if -1 < idx < len(gifts):
            gifts[idx] = command_param

    if command_text == 'JustInCase':
        gifts[-1] = command_param

    command_line = input()

for value in gifts:
    if value != 'None':
        result.append(value)

print(" ".join(result))