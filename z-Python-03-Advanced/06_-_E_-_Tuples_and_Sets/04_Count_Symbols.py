# 100/100

string = input()
string_set = set(string)
string_set = sorted(string_set)

for ch in string_set:
    count = string.count(ch)
    print(f'{ch}: {count} time/s')