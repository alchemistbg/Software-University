# 100/100

text = input()

stack = []

for idx, ch in enumerate(text):
    if ch == '(':
        stack.append(idx)

    if ch == ')':
        start = stack.pop()
        print(text[start:idx + 1])
