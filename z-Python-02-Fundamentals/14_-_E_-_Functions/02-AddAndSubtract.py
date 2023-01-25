# 100/100

def sum_numbers(a, b):
    return a + b


def subtract_numbers(a, b):
    return a - b


def add_and_subtract(n1, n2, n3):
    temp_result = sum_numbers(n1, n2)
    final_result = subtract_numbers(temp_result, n3)
    return final_result


q1 = int(input())
q2 = int(input())
q3 = int(input())

result = add_and_subtract(q1, q2, q3)
print(result)

