# bool_list = [False, True, True]
# print(any(bool_list))
# print(all(bool_list))


def test_func(a, b):
	sum_ = a + b
	return sum_


test_func.c = 25
print(test_func(2, 3))
print(test_func.c)
print(test_func.__dict__)
