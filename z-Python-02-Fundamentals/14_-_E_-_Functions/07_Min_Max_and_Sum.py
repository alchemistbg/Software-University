# 100/100

def convert_input(string):
    numbers = []
    string_list = string.split()
    for s in string_list:
        n = int(s)
        numbers.append(n)
    return numbers


string_input = input()
numbers = convert_input(string_input)
minimum = min(numbers)
print(f'The minimum number is {minimum}')
maximum = max(numbers)
print(f'The maximum number is {maximum}')
sum_of_numbers = sum(numbers)
print(f'The sum number is: {sum_of_numbers}')
