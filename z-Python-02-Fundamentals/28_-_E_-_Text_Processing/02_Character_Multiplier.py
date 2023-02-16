# 100/100

def arrange_strings_by_length(s1, s2):
    """
    Return longer of two strings
    :param s1: first string
    :param s2: second string
    :return: both strings, arranged by length (longer is first)
    """
    if len(s2) > len(s1):
        return s2, s1
    return s1, s2


string1, string2 = input().split()
long_string, short_string = arrange_strings_by_length(string1, string2)

short_string_length = len(short_string)
long_string_length = len(long_string)
diff = long_string_length - short_string_length

total_sum = 0

for idx in range(short_string_length):
    current = ord(short_string[idx]) * ord(long_string[idx])
    total_sum += current

if diff > 0:
    for ch in long_string[long_string_length - diff:]:
        total_sum += ord(ch)

print(total_sum)
