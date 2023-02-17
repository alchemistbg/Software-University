# 100/100

text = input()
result = ' '
for idx in range(len(text)):
    # THE COMMENTED CODE IS NOT NECESSARY! Still got the max result!
    # if idx < len(text) - 1 and text[idx] == text[idx + 1] and result[len(result) - 1] != text[idx]:
    #     result += text[idx]
    # if idx < len(text) - 1 and text[idx] != text[idx + 1] and result[len(result) - 1] != text[idx]:
    #     result += text[idx]
    if idx < len(text) - 1 and text[idx] != text[idx + 1]:
        result += text[idx]

if text[len(text) - 1] != result[len(result) - 1]:
    result += text[idx]

print(result)
