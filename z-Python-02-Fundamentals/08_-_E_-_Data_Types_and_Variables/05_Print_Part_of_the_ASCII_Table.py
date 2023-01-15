# 100/100

start = int(input())
end = int(input())

output = ''
for ch in range(start, end + 1):
    # print(chr(ch), end =' ')
    output += chr(ch) + ' '

print(output)
