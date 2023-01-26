# 100/100

def is_even(n):
    return n % 2 == 0


# def get_even_numbers(string):
#     numbers = []
#     for ch in string:
#         n = int(ch)
#         if is_even(n):
#             numbers.append(n)
#     return numbers
#
#
# def get_odd_numbers(string):
#     numbers = []
#     for ch in string:
#         n = int(ch)
#         if not is_even(n):
#             numbers.append(n)
#     return numbers

# This solution combines above functions into one in order to reduce repeated code
def separate_even_and_odds(string):
    evens = []
    odds = []
    for ch in string:
        n = int(ch)
        if is_even(n):
            evens.append(n)
        else:
            odds.append(n)
    return evens, odds


def calc_numbers_sum(numbers):
    return sum(numbers)


input_string = input()
# The following rows are using the commented functions above
# even_numbers = get_even_numbers(input_string)
# odd_numbers = get_odd_numbers(input_string)
even_numbers, odd_numbers = separate_even_and_odds(input_string)

even_sum = calc_numbers_sum(even_numbers)
odd_sum = calc_numbers_sum(odd_numbers)

print(f'Odd sum = {odd_sum}, Even sum = {even_sum}')