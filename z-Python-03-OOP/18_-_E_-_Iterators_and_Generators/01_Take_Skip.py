class take_skip:

	def __init__(self, step, count):
		self.step = step
		self.count = count
		self.counter = 0
		self.current = 0

	def __iter__(self):
		return self

	def __next__(self):
		current = self.current

		if self.counter == self.count:
			raise StopIteration

		self.counter += 1
		self.current += self.step
		return current


numbers1 = take_skip(2, 6)
for number in numbers1:
	print(number)

print(79 * '*')

numbers2 = take_skip(10, 5)
for number in numbers2:
	print(number)
