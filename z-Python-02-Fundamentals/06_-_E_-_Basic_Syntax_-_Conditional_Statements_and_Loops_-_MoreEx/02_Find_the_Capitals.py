# 100/100

string = input()

capitals = []

for idx in range (len(string)):
    if string[idx].isupper():
        capitals.append(idx)

print(capitals)

# Old solution for this problem
# lst = list(input())
# result = []
# for i in range (len(lst)):
#     ch = ord(lst[i])
#     if ch >= 65 and ch <= 90:
#         result.append(i)
# print(result)
