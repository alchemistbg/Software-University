# 100/100

def reverse_string(string):
    # 1.
    # return string[::-1]

    # 2
    reversed_string = reversed(string)
    return ''.join(reversed_string)


while True:
    word = input()
    if word == 'end':
        break

    reversed_word = reverse_string(word)
    print(f'{word} = {reversed_word}')