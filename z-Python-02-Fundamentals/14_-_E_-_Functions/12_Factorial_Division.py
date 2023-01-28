# 100/100

def calc_factorial(n):
    if n == 2:
        return 2
    else:
        return n * calc_factorial(n - 1)


def solver(a, b):
    factorial_a = calc_factorial(a)
    factorial_b = calc_factorial(b)

    division = factorial_a / factorial_b
    return division
    # return round(division, 2)


n1 = int(input())
n2 = int(input())
result = solver(n1, n2)
print(f'{result:.2f}')
# print(result)