# 100/100

def sorting_cheeses(**kwargs):
    sorted_kwargs = dict(sorted(kwargs.items(), key = lambda kvp: (-len(kvp[1]), kvp[0])))
    result = ''
    for kvp in sorted_kwargs.items():
        result += kvp[0] + '\n'
        sorted_qties = sorted(sorted_kwargs[kvp[0]], reverse = True)
        for qty in sorted_qties:
            result += str(qty) + '\n'
    return result

print(
    sorting_cheeses(
        Parmesan=[102, 120, 135],
        Camembert=[100, 100, 105, 500, 430],
        Mozzarella=[50, 125],
    )
)
print(
    sorting_cheeses(
        Parmigiano=[165, 215],
        Feta=[150, 515],
        Brie=[150, 125]
    )
)
