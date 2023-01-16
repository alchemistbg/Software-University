# 100/100

counter = int(input())

numbers_list = []

while counter > 0:
    number = int(input())
    numbers_list.append(number)
    counter -= 1

result_list = []
command = input()
for number in numbers_list:
    if command == 'even' and number % 2 == 0:
        result_list.append(number)
    if command == 'odd' and number % 2 != 0:
        result_list.append(number)
    if command == 'positive' and number >= 0:
        result_list.append(number)
    if command == 'negative' and number < 0:
        result_list.append(number)

print(result_list)
