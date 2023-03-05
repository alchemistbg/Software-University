# 100/100

lines = int(input())

stack = []

for _ in range(lines):
    line = input()
    if line.startswith('1 '):
        item = int(line.split()[1])
        stack.append(item)
    elif line == '2':
        if len(stack) > 0:
            stack.pop()
    elif line == '3':
        if len(stack) > 0:
            max_elem = max(stack)
            print(max_elem)
    elif line == '4':
        if len(stack) > 0:
            min_elem = min(stack)
            print(min_elem)

stack.reverse()
print(', '.join(map(str, stack)))
