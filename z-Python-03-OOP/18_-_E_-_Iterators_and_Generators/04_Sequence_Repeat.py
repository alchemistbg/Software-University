class sequence_repeat:

	def __init__(self, sequence, number):
		self.sequence = sequence
		self.number = number
		self.__idx = 0

	def __iter__(self):
		# self.__idx = 0
		return self

	def __next__(self):
		idx = self.__idx
		self.__idx += 1

		if self.__idx > self.number:
			raise StopIteration

		return self.sequence[idx % len(self.sequence)]


result = sequence_repeat('abc', 5)
for item in result:
	print(item, end = '')
