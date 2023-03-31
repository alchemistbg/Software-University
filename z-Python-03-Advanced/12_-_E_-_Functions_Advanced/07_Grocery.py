# 100/100

def  grocery_store(**kwargs):
    sorted_kwargs = dict(sorted(kwargs.items(), key = lambda kvp: (-kvp[1], -len(kvp[0]), kvp[0])))
    result = []
    for kvp in sorted_kwargs.items():
        result.append(f'{kvp[0]}: {kvp[1]}')
    return '\n'.join(result)


print(grocery_store(
    bread=5,
    pasta=12,
    eggs=12,
))
print(72*"*")
print(grocery_store(
    bread=2,
    pasta=2,
    eggs=20,
    carrot=1,
))
