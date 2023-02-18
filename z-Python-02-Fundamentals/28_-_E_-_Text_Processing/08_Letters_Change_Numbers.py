# 100/100

def get_letter_position(letter: str):
    upper_letter = letter.upper()
    return ord(upper_letter) - 64


text = input()
tokens = text.split()

result = 0

for token in tokens:
    f_letter = token[0]
    s_letter = token[-1]
    number = int(token[1:-1])

    if f_letter.isupper():
        number /= get_letter_position(f_letter)
        # print(number)
    else:
        number *= get_letter_position(f_letter)
        # print(number)

    if s_letter.isupper():
        number -= get_letter_position(s_letter)
        # print(number)
    else:
        number += get_letter_position(s_letter)
        # print(number)
    result += number

print(f'{result:.2f}')