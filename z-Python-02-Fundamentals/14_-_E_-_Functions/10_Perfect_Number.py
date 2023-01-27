# 100/100

def get_divisors(number):
    divisors = []
    half = number // 2
    for n in range(1, half):
        if number % n == 0:
            divisors.append(n)

    divisors.append(half)
    return divisors


def check_number(number):
    divisors = get_divisors(number)
    divisors_sum = sum(divisors)
    if divisors_sum != number:
        return False
    return True


number = int(input())
is_perfect = check_number(number)
if is_perfect:
    print('We have a perfect number!')
else:
    print('It\'s not so perfect.')

# A nice solution
# https://www.geeksforgeeks.org/perfect-number/