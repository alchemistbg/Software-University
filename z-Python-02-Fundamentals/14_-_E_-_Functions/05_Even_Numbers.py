# 100/100

def is_even(n):
    return n % 2 == 0


def filter_odd_numbers(numbers):
    even_numbers = list(filter(is_even, numbers))
    return even_numbers


def convert_string_to_list(string):
    string_list = string.split()
    numbers_list = []
    for s in string_list:
        n = int(s)
        numbers_list.append(n)
    return numbers_list


string = input()
numbers = convert_string_to_list(string)
even_numbers = filter_odd_numbers(numbers)
print(even_numbers)
