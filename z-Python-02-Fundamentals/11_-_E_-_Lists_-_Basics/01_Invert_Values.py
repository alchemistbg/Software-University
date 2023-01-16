# 100/100

string = input()

# This one-line approach uses list comprehension
# numbers_list = [int(ch) * -1 for ch in string.split(" ")]

# This multi-line solution uses classic approach
string_list = string.split(" ")
numbers_list = []

for letter in string:
    number = int(letter) * -1
    numbers_list.append(number)

print(numbers_list)
