# 100/100

word = input()
print(word[::-1])
# This approach uses string comprehension and range
# reversed_word = ""
# for idx in range(len(word) - 1, -1, -1):
#     reversed_word += word[idx]
# print(reversed_word)

# This approach uses list
# word_list = list(word)
# word_list.reverse()
# print("".join(word_list))

# This approach uses method that perform string reversion using list
# def reverse(string):
#     string = list(string)
#     string.reverse()
#     return "".join(string)
# print(reverse(word))
