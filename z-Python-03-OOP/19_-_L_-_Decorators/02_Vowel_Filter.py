def vowel_filter(function):

    def wrapper():
        elements = function()
        return [elem for elem in elements if elem in 'aeiouwy']

    return wrapper


@vowel_filter
def get_letters():
    return ["a", "b", "c", "d", "e"]


print(get_letters())
