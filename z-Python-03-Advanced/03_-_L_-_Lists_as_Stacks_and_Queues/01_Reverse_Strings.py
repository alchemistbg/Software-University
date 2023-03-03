# 100/100

string = input()

stack = []

for ch in string:
    stack.append(ch)

reversed = ''
while len (stack) > 0:
    item = stack.pop()
    reversed += item

print(reversed)
