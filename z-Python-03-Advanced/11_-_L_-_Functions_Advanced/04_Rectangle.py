def rectangle(a, b):
    if type(a) is not int or type(b) is not int:
        return 'Enter valid values!'

    parameter = 2 * a + 2 * b
    area = a * b

    result = f"Rectangle area: {area}\nRectangle perimeter: {parameter}"
    return result


print(rectangle(2, 10))
