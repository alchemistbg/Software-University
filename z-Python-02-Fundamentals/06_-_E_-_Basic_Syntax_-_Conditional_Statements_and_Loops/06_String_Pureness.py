# 100/100

string_qty = int(input())
string_counter = 0

while string_counter < string_qty:
    s = input()

    if ',' in s or '.' in s or '_' in s:
        print(f'{s} is not pure!')
    else:
        print(f'{s} is pure.')

    string_counter += 1
