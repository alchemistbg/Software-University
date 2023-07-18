def cache(function):
	log = {}

	def wrapper(number):
		if number not in log:
			result = function(number)
			log[number] = result
			return result

		return log[number]

	wrapper.log = log
	return wrapper


@cache
def fibonacci(n):
	if n < 2:
		return n
	else:
		return fibonacci(n - 1) + fibonacci(n - 2)


fibonacci(3)
print(fibonacci.log)

fibonacci(200)
print(fibonacci.log)
