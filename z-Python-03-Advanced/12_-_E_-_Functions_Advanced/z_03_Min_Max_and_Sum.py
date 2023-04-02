def min_max_sum(numbers):
    min_n = min(numbers)
    max_n = max(numbers)
    sum_n = sum(numbers)
    result = f'The minimum number is {min_n}\nThe maximum number is {max_n}\nThe sum number is: {sum_n}'

    return result


numbers = list(map(int, input().split()))
print(min_max_sum(numbers))
