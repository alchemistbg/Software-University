# 100/100

def calculate(op, n1, n2):
    result = 0
    if op == 'multiply':
        result = n1 * n2
    elif op == 'divide':
        result = n1 // n2
    elif op == 'add':
        result = n1 + n2
    elif op == 'subtract':
        result = n1 - n2
    else:
        result = 'Unknown operation!'
    return result


operation = input()
number1 = int(input())
number2 = int(input())

product = calculate(operation, number1, number2)
print(product)
