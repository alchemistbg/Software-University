class ValueCannotBeNegative(Exception):
    # """Value cannot be negative"""
    pass


for _ in range(0, 5):
    num = int(input())
    if num < 0:
        raise ValueCannotBeNegative("Value cannot be negative")
