# 100/100

# My solution
def grade_to_text(n):
    result = None

    if 2.00 <= n <= 2.99:
        result = 'Fail'
    elif 3.00 < n <= 3.49:
        result = 'Poor'
    elif 3.50 <= n <= 4.49:
        result = 'Good'
    elif 4.50 <= n <= 5.49:
        result = 'Very Good'
    elif 5.50 <= n <= 6.00:
        result = 'Excellent'
    else:
        result = None

    return result


# Lector's solution
# def grade_to_text(n):
#
#     if 2.00 <= n < 3.0:
#         return 'Fail'
#     if 3.0 <= n < 3.5:
#         return 'Poor'
#     if 3.5 <= n < 4.5:
#         return 'Good'
#     if 4.5 <= n < 5.5:
#         return 'Very Good'
#     if 5.50 <= n <= 6.00:
#         return 'Excellent'


grade = float(input())
text = grade_to_text(grade)
print(text)
