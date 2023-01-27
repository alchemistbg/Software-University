# 100/100

# def is_palindrome(string_input):
#     list_input = list(string_input)
#     list_reversed = reversed(list_input)
#     string_reversed = "".join(list_reversed)
#     return string_input == string_reversed

# strings = input().split(', ')
# for string in strings:
#     print(is_palindrome(string))


# A shorter version of the above function
def is_palindrome(string_input):
    reversed_string = string_input[::-1]
    return string_input == reversed_string


def solver(items):
    results = []
    for item in items:
        result = is_palindrome(item)
        results.append(str(result))
    return results


numbers = input().split(', ')
results = solver(numbers)
print("\n".join(results))
