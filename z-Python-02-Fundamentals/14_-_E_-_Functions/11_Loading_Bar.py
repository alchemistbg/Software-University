# 100/100

def create_loading_bar(number):
    remainder = 10 - number
    bar = '%' * number + '.' * remainder
    return bar


def solver(percentage):
    number = percentage // 10
    loading_bar = create_loading_bar(number)
    result = ''
    if percentage < 100:
        result = f'{percentage}% [{loading_bar}]\nStill loading...'
    else:
        result = f'{percentage}% Complete!\n[{loading_bar}]'

    return result


percents = int(input())
print(solver(percents))
