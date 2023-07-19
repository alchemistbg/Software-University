class store_results:

	def __init__(self, function):
		self.function = function

	def __call__(self, *args, **kwargs):
		result = self.function(*args, **kwargs)
		log = f"Function '{self.function.__name__}' was called. Result: {result}\n"
		self.logger(log)
		return result

	def logger(self, log):
		with open('07_Store_Results_-_Class_Decorator.txt', 'a') as f:
			f.write(log)


@store_results
def add(a, b):
	return a + b


@store_results
def mult(a, b):
	return a * b


add(2, 2)
mult(6, 4)
