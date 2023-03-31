# 100/100

def palindrome(word, idx):
    word_reversed = word[::-1]
    if word != word_reversed:
        return f'{word} is not a palindrome'
    return f'{word} is a palindrome'

print(palindrome("abcba", 0))
print(72 * '*')
print(palindrome("peter", 0))
