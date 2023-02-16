# 100/100

text = input()
digits = []
letters = []
others = []

for ch in text:
    if ch.isdigit():
        digits.append(ch)
    elif ch.isalpha():
        letters.append(ch)
    else:
        others.append(ch)

print(''.join(digits))
print(''.join(letters))
print(''.join(others))