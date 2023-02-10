# 100/100

string = input()
string = string.replace(' ', '')

chars = {}

for char in string:
    if char not in chars.keys():
        chars[char] = 0

    chars[char] += 1

[print(f'{key} -> {value}') for key, value in chars.items()]
