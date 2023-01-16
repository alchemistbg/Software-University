# 100/100

counter = 3

meerkat = []

while counter > 0:
    meerkat.append(input())
    counter -= 1

# meerkat.reverse()

# My solution
meerkat[0], meerkat[2] = meerkat[2], meerkat[0]

print(meerkat)
