# 100/100

# This solution uses repeating construction
# numbers = [int(num) for num in input().split(', ')]
#
# print(f"Positive: {', '.join([str(n) for n in numbers if n > -1])}")
# print(f"Negative: {', '.join([str(n) for n in numbers if n < 0])}")
# print(f"Even: {', '.join([str(n) for n in numbers if n % 2 == 0])}")
# print(f"Odd: {', '.join([str(n) for n in numbers if n % 2 != 0])}")


numbers_dict = {
    'Positive': [],
    'Negative': [],
    'Even': [],
    'Odd': [],
}
def classify_number(num):
    if num > -1:
        numbers_dict['Positive'].append(num)
    elif num < 0:
        numbers_dict['Negative'].append(num)
    if num % 2 == 0:
        numbers_dict['Even'].append(num)
    elif num % 2 != 0:
        numbers_dict['Odd'].append(num)

[classify_number(num) for num in map(int, input().split(', '))]
[print(f'{key}: {", ".join(map(str, value))}') for key, value in numbers_dict.items()]
