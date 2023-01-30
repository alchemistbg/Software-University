# 100/100

def check_is_palindrome(word):
    reverse_word = word[::-1]
    return word == reverse_word


def find_palindromes(words):
    palindromes = list(filter(check_is_palindrome, words))
    return palindromes


def count_palindrome(palindromes, palindrome):
    count = palindromes.count(palindrome)
    return count


words = input().split()
palindrome = input()
palindromes = find_palindromes(words)
palindrome_count = count_palindrome(palindromes, palindrome)
print(f'{palindromes}\nFound palindrome {palindrome_count} times')
