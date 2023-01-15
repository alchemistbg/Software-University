# 100/100

counter = int(input())

char_sum = 0

while counter > 0:
    char_ascii_code = ord(input())
    char_sum += char_ascii_code
    counter -= 1

print(f'The sum equals: {char_sum}')
