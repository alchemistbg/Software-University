# 100/100

letters = input().split(', ')
chars = {letter:ord(letter) for letter in letters}
print(chars)


# One line solution
print({letter:ord(letter) for letter in input().split(', ')})