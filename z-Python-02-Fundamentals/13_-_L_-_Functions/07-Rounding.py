# 100/100

def round_number(n):
    return round(n)


numbers = [float(x) for x in input().split()]
result = []
for number in numbers:
    rounded = round_number(number)
    result.append(rounded)
print(result)
