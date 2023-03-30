# 100/100

def concatenate(*args, **kwargs):
    result = ''.join(args)
    for kwarg in kwargs:
        if kwarg in result:
            result = result.replace(kwarg, kwargs[kwarg])

    return result


print(concatenate("Soft", "UNI", "Is", "Grate", "!", UNI="Uni", Grate="Great"))
print(72 * '*')
print(concatenate("I", " ", "Love", " ", "Cythons", C="P", s="", java='Java'))