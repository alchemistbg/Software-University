# 100/100

def func(param, type_int = None, type_float = None, type_str = None):
    if type_int:
        param = int(param)
        return param * 2

    if type_float:
        param = float(param)
        result = param * 1.5
        return f'{result:.2f}'

    if type_str:
        return f'${param}$'


def solver(t, i):
    if t == 'int':
        return func(i, type_int = True)
    if t == 'real':
        return func(i, type_float = True)
    if t == 'string':
        return func(i, type_str = True)


value_type = input()
value = input()
result = solver(value_type, value)
print(result)
