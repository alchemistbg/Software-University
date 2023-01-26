# 100/100

def convert_string_to_numbers(string):
    return [int(n) for n in string.split()]


def sort_numbers(numbers):
    return sorted(numbers)


string = input()
numbers = convert_string_to_numbers(string)
sorted_numbers = sort_numbers(numbers)
print(sorted_numbers)
