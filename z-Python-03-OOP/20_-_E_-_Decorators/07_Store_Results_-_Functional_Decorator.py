def store_results(function):
	def logger(log):
		with open('07_Store_Results_-_Functional_Decorator.txt', 'a') as f:
			f.write(log)

	def wrapper(*args, **kwargs):
		result = function(*args, **kwargs)
		log = f"Function '{function.__name__}' was called. Result: {result}\n"
		logger(log)

	return wrapper


@store_results
def add(a, b):
	return a + b


@store_results
def mult(a, b):
	return a * b


add(2, 2)
mult(6, 4)
