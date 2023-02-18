# 100/100

def extract_data(text: str, symbol1: str, symbol2: str):
    token_start = text.index(symbol1) + 1
    token_end = text.index(symbol2)
    return text[token_start:token_end]


counts = int(input())

for _ in range(counts):
    data = input()
    name = extract_data(data, '@', '|')
    age = extract_data(data, '#', '*')
    print(f'{name} is {age} years old.')
