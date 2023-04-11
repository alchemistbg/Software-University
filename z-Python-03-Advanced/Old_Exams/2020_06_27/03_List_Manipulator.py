# 100/100

def list_manipulator(numbers, *args):
    result = []
    if args[0] == 'add':
        if args[1] == 'beginning':
            result.extend(args[2:])
            result.extend(numbers)
        elif args[1] == 'end':
            result.extend(numbers)
            result.extend(args[2:])
    elif args[0] == 'remove':
        if args[1] == 'beginning':
            if len(args) > 2:
                result = numbers[args[2]:]
            else:
                result = numbers[1:]
        elif args[1] == 'end':
            if len(args) > 2:
                result = numbers[:-args[2]]
            else:
                result = numbers[:-1]
    return result


# print(list_manipulator([1,2,3], "remove", "end"))
# print(list_manipulator([1,2,3], "remove", "beginning"))
# print(list_manipulator([1,2,3], "add", "beginning", 20))
# print(list_manipulator([1,2,3], "add", "end", 30))
# print(list_manipulator([1,2,3], "remove", "end", 2))
# print(list_manipulator([1,2,3], "remove", "beginning", 2))
# print(list_manipulator([1,2,3], "add", "beginning", 20, 30, 40))
# print(list_manipulator([1,2,3], "add", "end", 30, 40, 50))

