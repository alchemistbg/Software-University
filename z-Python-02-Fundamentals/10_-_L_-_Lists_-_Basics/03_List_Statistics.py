counter = int(input())

positive_numbers = []
negative_numbers = []

while counter > 0:
    number = int(input())
    if number >= 0:
        positive_numbers.append(number)
    else:
        negative_numbers.append(number)
    counter -= 1

count_of_positives = len(positive_numbers)
sum_of_negatives = sum(negative_numbers)

print(positive_numbers)
print(negative_numbers)
print(f'Count of positives: {count_of_positives}\nSum of negatives: {sum_of_negatives}')
