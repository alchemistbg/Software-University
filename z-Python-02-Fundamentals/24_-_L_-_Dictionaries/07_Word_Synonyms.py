words_count = int(input())

counter = 0

syn_dictionary = {}

while counter < words_count:
    word = input()
    synonym = input()
    if not syn_dictionary.get(word):
        syn_dictionary[word] = []

    syn_dictionary[word].append(synonym)

    counter += 1

# This could be done with dict comprehension
for (word, synonyms) in syn_dictionary.items():
    
    print(f'{word} - {", ".join(synonyms)}')
