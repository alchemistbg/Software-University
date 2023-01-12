# 100/100

number = int(input())

for i in range(1111, 10000):
    test = i
    a = test % 10
    #     print(f"a: {a}")
    test = test // 10

    b = test % 10
    #     print(f"b: {b}")
    test = test // 10

    c = test % 10
    #     print(f"c: {c}")
    test = test // 10

    d = test
    #     print(f"d: {d}")

    if a == 0 or b == 0 or c == 0 or d == 0:
        continue

    if number % a == 0 and number % b == 0 and number % c == 0 and number % d == 0:
        print(i, end=" ")
