# 100/100

banned_words = input().split(', ')
text = input()

for banned_word in banned_words:
    t = '*' * len(banned_word)
    text = text.replace(banned_word, t)

print(text)
