# 100/100

s = input()
s_out = []

while s != 'End':
    if s != 'SoftUni':
        for idx in range(len(s)):
            s_out.append(s[idx] * 2)

            # Next two rows are part of a same solution  
            # print(s[idx] * 2, end = '')
        # print("".join(s_out))

        print()
        s_out = []

    s = input()
