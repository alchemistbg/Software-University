# 100/100

numbers = [int(s) for s in input().split(', ')]

shifted = []

for number in numbers:
    if number != 0:
        shifted.append(number)

for idx in range(len(shifted) - 1, len(numbers) - 1):
    shifted.append(0)

print(shifted)
