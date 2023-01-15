# 100/100

counter = int(input())

letter = chr(97 + counter)
for f_letter in range(counter):
    for s_letter in range(counter):
        for t_letter in range(counter):
            print(f'{chr(97 + f_letter)}{chr(97 + s_letter)}{chr(97 + t_letter)}')
