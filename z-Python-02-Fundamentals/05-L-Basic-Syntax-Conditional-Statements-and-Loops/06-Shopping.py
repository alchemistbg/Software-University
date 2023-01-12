budget = int(input())

line = input()
while not line == 'End':
    price = int(line)
    budget -= price

    if budget < 0:
        print('You went in overdraft!')
        break

    line = input()
else:
    print('You bought everything needed.')
