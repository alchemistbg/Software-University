# 100/100

a = int(input())
b = int(input())

print(f'''Before:
a = {a}
b = {b}
''', end="")

temp = a
a = b
b = temp

print(f'''After:
a = {a}
b = {b}''')
