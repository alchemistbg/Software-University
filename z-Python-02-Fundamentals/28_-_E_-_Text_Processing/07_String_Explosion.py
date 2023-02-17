# 100/100

text = input()
tokens = text.split('>')

remainder = 0
for idx, token in enumerate(tokens):
    if idx > 0:
        explosion = int(token[0]) + remainder
        tokens[idx] = token[explosion:]
        if explosion > len(token):
            remainder = explosion - len(token)

print('>'.join(tokens))
