from collections import deque
import operator

working_bees = deque(map(int, input().split()))
nectars = deque(map(int, input().split()))
honey_ops = deque(input().split())
ops = {
    '+': operator.add,
    '-': operator.sub,
    '*': operator.mul,
    '/': operator.truediv
}

total_honey = 0

while working_bees and nectars:
    working_bee = working_bees[0]
    nectar = nectars[-1]
    op = honey_ops[0]
    if nectar >= working_bee:
        # honey = ops[op](working_bee, nectar)
        honey = 0
        if op == '+':
            honey = working_bee + nectar
        elif op == '-':
            honey = working_bee - nectar
        elif op == '*':
            honey = working_bee * nectar
        elif op == '/' and nectar != 0:
            honey = working_bee / nectar

        total_honey += abs(honey)
        working_bees.popleft()
        nectars.pop()
        honey_ops.popleft()
    else:
        nectars.pop()

print(f'Total honey made: {total_honey}')
if working_bees:
    print(f'Bees left: {", ".join(map(str, working_bees))}')
if nectars:
    print(f'Nectar left: {", ".join(map(str, nectars))}')
