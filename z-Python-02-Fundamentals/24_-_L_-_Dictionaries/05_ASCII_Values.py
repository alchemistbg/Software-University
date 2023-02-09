# 100/100

# chars = input().split(', ')
# chars_dict = {}
#
# for char in chars:
#     chars_dict[char] = ord(char)
#
# print(chars_dict)

# One line solution using dict comprehension - 100/100
print({char: ord(char) for char in input().split(', ')})
