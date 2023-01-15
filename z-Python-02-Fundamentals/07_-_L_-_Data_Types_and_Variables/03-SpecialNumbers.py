# 100/100
# Old solution - uses two loops
# number = int(input())
#
# for i in range(1, number + 1):
#     int_sum = 0
#     temp = i
#
#     while temp > 0:
#         n = temp % 10
#         int_sum += n
#         temp = int(temp // 10)
#
#     if int_sum == 5 or int_sum == 7 or int_sum == 11:
#         print(f"{i} -> True")
#     else:
#         print(f"{i} -> False")

# 100/100
# This is the lector's solution
# integer = int(input())
#
# for number in range(1, integer + 1):
#     sum_of_digits = 0
#
#     for ch in str(number):
#         sum_of_digits += int(ch)
#
#     is_special = sum_of_digits in (5, 7, 11)
#     print(f'{number} -> {is_special}')

# 100/100
integer = int(input())

for i in range(1, integer + 1):
    string = str(i)
    int_list = list(map(int, string))
    int_sum = sum(int_list)

    # is_special = int_sum == 5 or int_sum == 7 or int_sum == 11
    is_special = int_sum in (5, 7, 11)  # Using a tuple

    print(f'{i} -> {is_special}')
