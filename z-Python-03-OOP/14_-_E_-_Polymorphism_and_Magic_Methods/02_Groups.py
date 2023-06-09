class Person:

	def __init__(self, name: str, surname: str):
		self.name = name
		self.surname = surname

	def __add__(self, other: 'Person'):
		return Person(self.name, other.surname)

	def __repr__(self):
		return f"{self.name} {self.surname}"