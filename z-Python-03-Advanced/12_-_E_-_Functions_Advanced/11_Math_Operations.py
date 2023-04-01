# 100/100

def math_operations(*args, **kwargs):
    result = ''
    for idx, arg in enumerate(args):
        pos = (idx + 1) % 4
        arg = float(arg)
        if pos == 1:
            kwargs['a'] += arg
        elif pos == 2:
            kwargs['s'] -= arg
        elif pos == 3 and arg != 0:
            kwargs['d'] /= arg
        else:
            kwargs['m'] *= arg

    sorted_kwargs = sorted(kwargs.items(), key = lambda kvp: (-kvp[1], kvp[0]))
    for sorted_kwarg in sorted_kwargs:
        result += f'{sorted_kwarg[0]}: {sorted_kwarg[1]:.1f}\n'
    return result


print(math_operations(2.1, 12.56, 0.0, -3.899, 6.0, -20.65, a=1, s=7, d=33, m=15))
print(72 * '*')
print(math_operations(-1.0, 0.5, 1.6, 0.5, 6.1, -2.8, 80.0, a=0, s=(-2.3), d=0, m=0))
print(72 * '*')
print(math_operations(6.0, a=0, s=0, d=5, m=0))
