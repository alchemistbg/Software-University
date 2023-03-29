# 100/100
def separate_numbers(numbers):
    negatives = list(filter(lambda x: x < 0, numbers))
    positives = list(filter(lambda x: x > 0, numbers))
    return negatives, positives

def sum_numbers(numbers):
    return sum(numbers)

def print_result(neg_sum, pos_sum):
    print(neg_sum)
    print(pos_sum)
    if abs(neg_sum) > pos_sum:
        print('The negatives are stronger than the positives')
    else:
        print('The positives are stronger than the negatives')


numbers = list(map(int, input().split()))
neg, pos = separate_numbers(numbers)
neg_sum = sum_numbers(neg)
pos_sum = sum_numbers(pos)
print_result(neg_sum, pos_sum)
