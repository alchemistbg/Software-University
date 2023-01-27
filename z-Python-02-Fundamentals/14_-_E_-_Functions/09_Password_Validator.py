# 100/100

def validate_length(password):
    password_length = len(password)
    if password_length < 6 or password_length > 10:
        return 'Password must be between 6 and 10 characters'


def validate_content(password):
    if not password.isalnum():
        return 'Password must consist only of letters and digits'


def validate_digits(password):
    digits = 0
    for ch in password:
        if ch.isdigit():
            digits += 1
    if digits < 2:
        return 'Password must have at least 2 digits'


def validate_password(password):
    check_results = []

    vaslidators = [validate_length, validate_content, validate_digits]
    for validator in vaslidators:
        validation_result = validator(password)
        if validation_result is None:
            continue

        check_results.append(validation_result)

    return check_results


password = input()
validation_results = validate_password(password)
if len(validation_results) == 0:
    print('Password is valid')
else:
    print("\n".join(validation_results))
