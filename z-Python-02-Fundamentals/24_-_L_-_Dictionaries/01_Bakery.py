# 100/100

# tokens = input().split()

# My original solution
# products_names = [tokens[i] for i in range(len(tokens)) if i % 2 == 0]
# products_quantities = [int(tokens[i]) for i in range(len(tokens)) if i % 2 != 0]

# A lot more fast way to select every n-th element in python list
# products_names = tokens[0::2]
# products_quantities = tokens[1::2]

# The rest of the above solutions
# products = {}
# for idx in range(len(products_names)):
#     products[products_names[idx]] = int(products_quantities[idx])

# Solution with dictionary comprehension
tokens = input().split()
products = {tokens[idx]: int(tokens[idx + 1]) for idx in range(0, len(tokens), 2)}

# Printing the final dictionary
print(products)
