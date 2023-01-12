# 100/100

number = int(input())

# This variant uses two 'for' cycles
# for r1 in range (1, number + 1):
#     print(r1 * "*")
# for r2 in range(number - 1, 0, -1):
#     print(r2 * "*")

# This variant uses one 'for' cycle
for i in range(1, number * 2):
    if i <= number:
        print('*' * i)
    else:
        print('*' * (2 * number - i))
