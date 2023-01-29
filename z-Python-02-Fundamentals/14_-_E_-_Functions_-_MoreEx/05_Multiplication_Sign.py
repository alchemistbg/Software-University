# 100/100

def get_sign(numbers):
    negative_counter = 0
    for number in numbers:
        if number == 0:
            return 'zero'

        if number < 0:
            negative_counter += 1

    if negative_counter % 2 == 0:
        return 'positive'
    return 'negative'

n1 = int(input())
n2 = int(input())
n3 = int(input())
numbers = [n1, n2, n3]
sign = get_sign(numbers)
print(sign)
