# 100/100

lines = int(input())

left_brackets = 0
right_brackets = 0

while lines > 0:
    line = input()

    if left_brackets == 0 and right_brackets == 0 and ')' in line:
        print('UNBALANCED')
        break

    if left_brackets - right_brackets > 1:
        print('UNBALANCED')
        break

    if '(' in line:
        left_brackets += 1

    if ')' in line:
        right_brackets += 1

    lines -= 1
else:
    if left_brackets == right_brackets:
        print('BALANCED')
    else:
        print('UNBALANCED')
