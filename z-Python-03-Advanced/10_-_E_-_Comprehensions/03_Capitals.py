# 100/100

# countries = input().split(', ')
# capitals = input().split(', ')
#
# data = {country:capital for (country, capital) in zip(countries, capitals)}
#
# [print(f'{cou} -> {cap}') for (cou, cap) in data.items()]


# One liner
[print(f'{cou} -> {cap}') for (cou, cap) in {country:capital for (country, capital) in zip(input().split(', '), input().split(', '))}.items()]
