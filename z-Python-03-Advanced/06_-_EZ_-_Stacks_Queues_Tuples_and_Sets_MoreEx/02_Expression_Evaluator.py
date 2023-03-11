from collections import deque
import operator


def calculate(numbers, op):
    ops = {
        '+': operator.add,
        '-': operator.sub,
        '*': operator.mul,
        '/': operator.floordiv
    }
    temp_result = 0
    for idx in range(1, len(numbers)):
        if idx == 1:
            temp_result = ops[op](numbers[idx-1], numbers[idx])
            continue

        temp_result = ops[op](temp_result, numbers[idx])

    return temp_result


data = deque(input().split())

operators = {"*", "+", "-", "/"}
current_numbers = []

result = 0
while len(data) > 0:
    d = data.popleft()
    if d not in operators:
        d = int(d)
        current_numbers.append(d)
    else:
        result = calculate(current_numbers, d)
        data.appendleft(result)
        current_numbers.clear()
print(result)
