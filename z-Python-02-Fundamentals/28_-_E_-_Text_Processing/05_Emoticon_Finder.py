# 100/100

text = input()

emoticons = []

for idx in range(len(text)):
    if text[idx] == ":":
        emoticon = text[idx : idx + 2]
        print(emoticon)
