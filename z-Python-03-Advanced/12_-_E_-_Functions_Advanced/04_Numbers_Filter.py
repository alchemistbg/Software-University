# 100/100 This solution uses the approach from the previous problem

def even_odd_filter(**kwargs):
    import operator
    result = {}
    ops = {
        'even': operator.eq,
        'odd': operator.ne,
    }
    for key in kwargs.keys():
        result[key] = list(filter(lambda n: ops[key](n%2, 0), kwargs[key]))

    result = dict(sorted(result.items(), key = lambda kvp: -len(kvp[1])))

    return result

print(even_odd_filter(
    odd=[1, 2, 3, 4, 10, 5],
    even=[3, 4, 5, 7, 10, 2, 5, 5, 2],
))
