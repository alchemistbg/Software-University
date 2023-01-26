# 100/100

def find_smallest(q1, q2, q3):
    # return min(q1, q2, q3)

    # My implementation
    smallest = None
    if q1 < q2 and q1 < q3:
        smallest = q1
    if q2 < q1 and q2 < q3:
        smallest = q2
    if q3 < q1 and q3 < q2:
        smallest = q3

    return smallest
    # smallest can be initialized as follows: smallest = c. This makes third if-check redundant


n1 = int(input())
n2 = int(input())
n3 = int(input())
result = find_smallest(n1, n2, n3)
print(result)
