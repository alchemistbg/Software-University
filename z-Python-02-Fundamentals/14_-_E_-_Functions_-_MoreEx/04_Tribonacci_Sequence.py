# 100/100

def get_tribunacci(n):
    tribunacci = [1, 1, 2]

    while len(tribunacci) < n:
        next = tribunacci[-1] + tribunacci[-2] + tribunacci[-3]
        tribunacci.append(next)

    return tribunacci[0:n]


def format_tribunacci(tribunacci):
    formatted_tribunacci = list(map(str, tribunacci))
    result = ' '.join(formatted_tribunacci)
    return result


counter = int(input())
tribunacci = get_tribunacci(counter)
tribunacci = format_tribunacci(tribunacci)
print(tribunacci)