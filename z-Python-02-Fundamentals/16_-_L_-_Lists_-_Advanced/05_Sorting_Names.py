# 100/100

def sorted_fn(name):
    return -len(name), name


names = input().split(', ')

# names = sorted(names, key = sorted_fn) # This variant uses external function as key parameter
names = sorted(names, key = lambda name: (-len(name), name)) # This variant uses lambda function as key parameter

print(names)
