# 100/100

rows = int(input())

for row in range(0, rows):
    number = int(input())
    if not number % 2 == 0:
        print(f'{number} is odd!')
        break
else:
    print('All numbers are even.')
