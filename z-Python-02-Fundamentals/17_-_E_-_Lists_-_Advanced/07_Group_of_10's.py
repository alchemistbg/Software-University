# 100/100

numbers = [int(n) for n in input().split(', ')]

upper_boundary = 10

while len(numbers) > 0:
    filtered = [n for n in numbers if n <= upper_boundary]
    numbers = [n for n in numbers if n not in filtered]
    print(f'Group of {upper_boundary}\'s: {filtered}')
    upper_boundary += 10
