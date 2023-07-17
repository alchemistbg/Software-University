# def upper_case(function):
#
# 	def wrapper():
# 		result = function()
# 		upper_case_result = result.upper()
# 		return upper_case_result
#
# 	return wrapper
#
#
# @upper_case
# def say_hi():
# 	return 'hi'
#
#
# print(say_hi())


# import sys
# import time
# from functools import lru_cache
#
# # Increase maximum recursive calls
# sys.setrecursionlimit(10000)
#
#
# def measure_time(function):
# 	def wrapper(*args, **kwargs):
# 		start = time.time()
# 		res = function(*args, **kwargs)
# 		end = time.time()
# 		total = end - start
# 		print(f'Total tme: {total}')
# 		return res
#
# 	return wrapper
#
#
# @measure_time
# def fibonacci(n):
#
# 	@lru_cache(50)
# 	def fib_recurse(n):
# 		if n == 0:
# 			return 0
#
# 		if n == 1:
# 			return n
#
# 		return fib_recurse(n - 1) + fib_recurse(n - 2)
#
# 	return fib_recurse(n)
#
#
# print(fibonacci(1000))

def increase_by_number(n):
	def decorator(function):
		def wrapper(*args, **kwargs):
			result = function(*args, **kwargs)
			return [x + n for x in result]
		return wrapper
	return decorator


@increase_by_number(30)
def test_function():
	return [1, 2, 3]


print(test_function())