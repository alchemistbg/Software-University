# 100/100

countries = input().split(', ')
capitals = input().split(', ')

data = dict(zip(countries, capitals))
[print(f'{country} -> {capital}') for country, capital in data.items()]
