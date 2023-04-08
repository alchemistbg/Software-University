import operator

def parse(expr:str):
    n1, sign, n2 = expr.split()
    ops = {
        "+": operator.add,
        "-": operator.sub,
        "*": operator.mul,
        "/": operator.truediv,
        "^": operator.pow,
    }
    op = ops[sign]
    return op, float(n1), float(n2)