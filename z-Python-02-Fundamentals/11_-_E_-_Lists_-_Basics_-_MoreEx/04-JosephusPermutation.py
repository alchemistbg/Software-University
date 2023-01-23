# 100/100

numbers = [int(n) for n in input().split()]
step = int(input())

numbers_length = len(numbers)
current_pos = -1
counter = 0

order = []

while numbers_length > 0:
    current_pos += 1
    counter += 1

    if counter == step:
        if current_pos > numbers_length - 1:
            current_pos = current_pos % numbers_length

        number = numbers.pop(current_pos)
        order.append(number)

        current_pos -= 1
        counter = 0

    numbers_length = len(numbers)

result = map(str, order)
print(f'[{",".join(result)}]')
