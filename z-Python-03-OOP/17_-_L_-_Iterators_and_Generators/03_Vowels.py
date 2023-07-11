# Solution with iterator
# class vowels:
#
# 	def __init__(self, string):
# 		self.string = string
# 		self. i = 0
# 		self.end = len(string)
#
# 	def __iter__(self):
# 		return self
#
# 	def __next__(self):
# 		while self.i < self.end:
# 			current = self.i
# 			self.i += 1
# 			if self.is_vowel(self.string[current]):
# 				return self.string[current]
# 		raise StopIteration
#
# 	def is_vowel(self, c: str):
# 		return c.upper() in 'AEIOUYW'


# Solution with generator function
def vowels(s):
	for c in s:
		if c.lower() in 'aeiouyw':
			yield c


my_string = vowels('Iteratori')
for char in my_string:
	print(char)
