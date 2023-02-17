# 100/100

text = input()

ciphered_text = ''

for ch in text:
    ciphered_ch = ord(ch) + 3
    ciphered_text += chr(ciphered_ch)

print(ciphered_text)