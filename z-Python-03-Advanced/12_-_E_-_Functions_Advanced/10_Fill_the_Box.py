# 100/100

def fill_the_box(height, width, length, *args):
    cubes = height * width * length

    for idx, arg in enumerate(args):
        if arg == 'Finish':
            return f'There is free space in the box. You could put {cubes} more cubes.'

        arg = int(arg)

        if cubes >= arg:
            cubes -= arg
        else:
            diff = arg - cubes + sum(args[idx + 1:-1])
            return f'No more free space! You have {diff} more cubes.'


print(fill_the_box(2, 8, 2, 2, 1, 7, 3, 1, 5, "Finish"))
print(72 * '*')
print(fill_the_box(5, 5, 2, 40, 11, 7, 3, 1, 5, "Finish"))
print(72 * '*')
print(fill_the_box(10, 10, 10, 40, "Finish", 2, 15, 30))
