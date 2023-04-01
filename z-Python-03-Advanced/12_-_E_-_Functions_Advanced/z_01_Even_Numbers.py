def filter_even(numbers):
    return list(filter(lambda x: x % 2 == 0, numbers))

numbers = list(map(int, input().split()))
print(filter_even(numbers))