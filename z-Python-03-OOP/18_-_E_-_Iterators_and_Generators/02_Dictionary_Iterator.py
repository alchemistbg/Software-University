from typing import Dict, Any


class dictionary_iter:

	def __init__(self, dictionary: Dict[Any, Any]):
		self.dictionary = dictionary
		self.__items = iter(self.dictionary.items())

	# 1st solution __iter__ and __next__ methods - 100/100 in judge
	def __iter__(self):
		return self

	def __next__(self):
		value = next(self.__items)
		return value

	# 2nd solution __iter__ method (__next__ is empty) - pass the zero tests, but not the judge
	# def __iter__(self):
	# 	return iter([(key, value) for key, value in self.dictionary.items()])


result1 = dictionary_iter({1: "1", 2: "2"})
for x in result1:
	print(x)

result2 = dictionary_iter({"name": "Peter", "age": 24})
for x in result2:
	print(x)
