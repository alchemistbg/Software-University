# 100/100

numbers = [int(string) for string in input().split(', ')]
even_indexes = [idx for idx, number in enumerate(numbers) if number % 2 == 0]
print(even_indexes)
