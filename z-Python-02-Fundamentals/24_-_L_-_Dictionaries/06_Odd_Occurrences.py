# 100/100

words = input().split()

words_dict = {}

for word in words:
    word = word.lower()
    if word not in words_dict.keys():
        words_dict[word] = 0

    words_dict[word] += 1

odd_words = [word for (word, count) in words_dict.items() if count % 2 != 0]
print(' '.join(odd_words))
