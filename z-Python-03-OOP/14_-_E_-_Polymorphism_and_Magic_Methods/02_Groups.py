from typing import List


class Person:

	def __init__(self, name: str, surname: str):
		self.name = name
		self.surname = surname

	def __add__(self, other: 'Person'):
		if not isinstance(other, self.__class__):
			raise TypeError(f"Unsupported operand type for '+': "
							f"'{self.__class__.__name__}' and '{other.__class__.__name__}'")
		return Person(self.name, other.surname)

	def __repr__(self):
		return f"{self.name} {self.surname}"


class Group:

	def __init__(self, name, people: List[Person]):
		self.name = name
		self.people = people

p0 = Person('Aliko', 'Dangote')
p1 = Person('Bill', 'Gates')
p2 = Person('Warren', 'Buffet')
p3 = Person('Elon', 'Musk')
p4 = p2 + p3

print(p0)
print(p4)

first_group = Group('__VIP__', [p0, p1, p2])
second_group = Group('Special', [p3, p4])
# third_group = first_group + second_group
