# 100/100

n1 = int(input())
n2 = int(input())
op = input()

ops1 = "+ - *"
ops2 = "/ %"

result = 0
isEven = "odd"

if op in ops2 and n2 == 0:
    print(f"Cannot divide {n1} by zero")
else:
    if op == "+":
        result = n1 + n2
    elif op == "-":
        result = n1 - n2
    elif op == "*":
        result = n1 * n2
    elif op == "/":
        result = n1 / n2
    elif op == "%":
        result = n1 % n2

    if (op in ops1):
        if (result % 2) == 0:
            isEven = "even"
        print(f"{n1} {op} {n2} = {result} - {isEven}")
    elif op == "/":
        print(f"{n1} {op} {n2} = {result:.2f}")
    elif op == "%":
        print(f"{n1} {op} {n2} = {result}")
