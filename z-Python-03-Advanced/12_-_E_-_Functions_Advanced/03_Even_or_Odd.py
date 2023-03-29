# 100/100

# This solution uses if/else block
def even_odd(*args):
    command = args[-1]
    if command == 'even':
        result = list(filter(lambda n: n % 2 == 0, args[0:-1]))
    else:
        result = list(filter(lambda n: n % 2 != 0, args[0:-1]))
    return result


# This solution uses dictionary with operators
def even_odd(*args):
    import operator
    command = args[-1]
    ops = {
        'even': operator.eq,
        'odd': operator.ne,
    }
    result = list(filter(lambda n: ops[command](n%2, 0), args[0:-1]))
    return result

print(even_odd(1, 2, 3, 4, 5, 6, "even"))
print(72 * '*')
print(even_odd(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, "odd"))
