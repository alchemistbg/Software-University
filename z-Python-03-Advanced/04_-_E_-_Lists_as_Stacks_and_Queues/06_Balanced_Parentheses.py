# 100/100

text = input()

stack = []
is_balanced = True

for idx, ch in enumerate(text):
    if ch == '(' or ch == '[' or ch == '{':
        stack.append(ch)
    else:
        if len(stack) > 0:
            old_ch = stack.pop()
        else:
            is_balanced = False
            break

        if old_ch == '(' and ch != ')':
            is_balanced = False
            break
        elif old_ch == '[' and ch != ']':
            is_balanced = False
            break
        elif old_ch == '{' and ch != '}':
            is_balanced = False
            break

if len(stack):
    is_balanced = False

if is_balanced:
    print('YES')
else:
    print('NO')
