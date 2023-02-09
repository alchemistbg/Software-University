# 100/100

data = input().split()

products_names = data[0::2]
products_quantities = data[1::2]

stock = {}

for idx in range(len(products_names)):
    stock[products_names[idx]] = int(products_quantities[idx])

queries = input().split()

for query in queries:
    if query in stock.keys():
        print(f"We have {stock[query]} of {query} left")
    else:
        print(f"Sorry, we don't have {query}")