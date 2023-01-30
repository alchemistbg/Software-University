# 100/100

def filter_vowels(string):
    vowels = ['a', 'o', 'u', 'e', 'i']
    filtered_string = [ch for ch in string if ch not in vowels]
    return "".join(filtered_string)


string = input()
result = filter_vowels(string)
print(result)
