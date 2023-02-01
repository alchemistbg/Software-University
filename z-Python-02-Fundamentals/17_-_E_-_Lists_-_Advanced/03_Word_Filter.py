# 100/100

strings = input().split()
filtered = [string for string in strings if len(string) % 2 == 0]
print('\n'.join(filtered))\
