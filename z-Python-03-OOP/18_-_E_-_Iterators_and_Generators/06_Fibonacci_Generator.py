def fibonacci():
	first = 0
	second = 1

	# Longer form of the while cycle
	while True:
		yield first
		fs_sum = first + second
		first = second
		second = fs_sum

	# Shorter form of the while cycle
	# while True:
	# 	yield first
	# 	first, second = second, first + second


generator = fibonacci()
for i in range(5):
	print(next(generator))
