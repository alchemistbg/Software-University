# 100/100

def string_to_numbers(s):
    return float(s)


def abs_values(n):
    return abs(n)


strings = input().split()
abs_numbers = []

for s in strings:
    n = string_to_numbers(s)
    an = abs_values(n)
    abs_numbers.append(an)

print(abs_numbers)
