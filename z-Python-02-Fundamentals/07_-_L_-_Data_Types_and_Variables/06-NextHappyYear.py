# 100/100
# This solution works fine, but I want to beautify it.
# I want to test other idea

curr_year = input()
limit = len(curr_year)

increment = 1
while True:
    temp = int(curr_year) + increment
    l = set(str(temp))
    if len(l) == len(curr_year):
        print(temp)
        break
    increment += 1

# curr_year = int(input)
# happy_year = 0
# while True:
#
#     curr_year += 1
#
# print(happy_year)
