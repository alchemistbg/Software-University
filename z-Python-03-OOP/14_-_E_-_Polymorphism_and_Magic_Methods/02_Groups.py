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

	def __add__(self, other: 'Group'):
		if not isinstance(other, self.__class__):
			raise TypeError(f"Unsupported operand type for '+': "
							f"'{self.__class__.__name__}' and '{other.__class__.__name__}'")
		new_name = f'{self.name} {other.name}'
		new_people = self.people + other.people
		return Group(new_name, new_people)

	def __len__(self):
		return len(self.people)

	# TODO - test for this methods
	def __repr__(self):
		members = ", ".join((map(str, self.people)))
		return f"Group {self.name} with members {members}"

	def __getitem__(self, idx: int):
		return f"Person {idx}: {self.people[idx]}"


# # Problem's author test
# p0 = Person('Aliko', 'Dangote')
# p1 = Person('Bill', 'Gates')
# p2 = Person('Warren', 'Buffet')
# p3 = Person('Elon', 'Musk')
# p4 = p2 + p3
#
# print(p0)
# print(p4)
#
# first_group = Group('__VIP__', [p0, p1, p2])
# second_group = Group('Special', [p3, p4])
# # third_group = first_group + second_group
#
# print(len(first_group))
# print(second_group)
# print(third_group[0])
#
# for person in third_group:
# 	print(person)


# Custom tests based on lecturer ideas
def test_successfully_adding_people():
	p1 = Person('Bill', 'Gates')
	p2 = Person('Warren', 'Buffet')
	assert str(p1 + p2) == 'Bill Buffet', p1 + p2
	print("People can be added")


def test_unsuccessfully_adding_people():
	p1 = Person('Johny', 'Depp')
	try:
		p1 + 2
	except TypeError:
		print("Person can't be added to a number")
	except Exception as e:
		assert False, f'Expected TypeError, got {e.__class__.__name__}'
	else:
		assert False, 'Expected TypeError, got nothing'


def test_successfully_adding_groups():
	p1 = Person('Johny', 'Depp1')
	p2 = Person('Johny', 'Depp2')
	p3 = Person('Johny', 'Depp3')
	p4 = Person('Johny', 'Depp4')
	g1 = Group('G1', [p1, p2])
	g2 = Group('G2', [p3, p4])
	g3 = g1 + g2
	assert len(g3.people) == 4, f"Expected 4, got {len(g3.people)}"
	print("Groups can be added")


# TODO
# def test_successfully_adding_groups(): -> different types

def test_get_group_length():
	p1 = Person('P1', 'P2')
	p2 = Person('P1', 'P2')
	g = Group('G1', [p1, p2])
	assert len(g) == 2, f"Expected 2, got {len(g)}"
	print("Groups has len()")


def test_get_group_repr():
	p1 = Person('P1', 'P2')
	p2 = Person('P1', 'P2')
	g = Group('G1', [p1, p2])
	print(g)


test_successfully_adding_people()
test_unsuccessfully_adding_people()
test_successfully_adding_groups()
test_get_group_length()
test_get_group_repr()
