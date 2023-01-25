# 100/100

codes = input().split()
text = list(input())

message = ''
counter = 0

for code in codes:
    idx = 0

    for ch in code:
        idx += int(ch)
    idx = idx % len(text)

    message += text[idx + counter]
    counter += 1
    # text.pop(idx)

print(message)
