# 100/100

def age_assignment(*args, **kwargs):
    sorted_args = sorted(args)
    result = ""
    for name in sorted_args:
        first_letter = name[0]
        result += f'{name} is {kwargs[first_letter]} years old.\n'
    result.strip('a')
    return result


print(age_assignment("Peter", "George", G=26, P=19))
print(72 * '*')
print(age_assignment("Amy", "Bill", "Willy", W=36, A=22, B=61))
