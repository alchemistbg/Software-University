# 100/100

text = input()

result = ''
current = ''
repeats = 0
for idx, ch in enumerate(text):
    if ch.isnumeric():
        repeats = ch
        if idx < len(text) - 1 and text[idx + 1].isnumeric():
            repeats += text[idx + 1]

        repeats = int(repeats)
        current = current * repeats
        result += current
        current = ''
        repeats = 0
    else:
        current += ch.upper()

print(f'Unique symbols used: {len(set(result))}')
print(result)
