def even_or_odd(command, numbers):
    import operator
    length = len(numbers)
    commands = {
        'Odd': operator.ne,
        'Even': operator.eq
    }
    filtered_numbers = list(filter(lambda n: commands[command](n % 2, 0), numbers))
    sum_filtered_numbers = sum(filtered_numbers)
    result = sum_filtered_numbers * length
    return result


command = input()
numbers = list(map(int, input().split()))
print(even_or_odd(command, numbers))
