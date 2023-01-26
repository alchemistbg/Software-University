# 100/100

def print_characters(ch1, ch2):
    start = ord(ch1) + 1
    end = ord(ch2)
    chars = []

    for ch in range(start, end):
        char = chr(ch)
        chars.append(char)

    result = ' '.join(chars)
    return result


ch1 = input()
ch2 = input()
print(print_characters(ch1, ch2))
