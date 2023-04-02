def sort_numbers(numbers):
    return list(sorted(numbers))

numbers = list(map(int, input().split()))
print(sort_numbers(numbers))
