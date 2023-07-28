# from typing import List, Union
# from project.people.child import Child
# from project.appliances.appliance import Appliance


class Room:

	def __init__(self, name: str, budget: float, members_count: int, children = []):
		self.family_name = name
		self.budget = budget
		self.members_count = members_count
		self.children = children
		self.__expenses = 0

	@property
	def expenses(self):
		return self.__expenses

	@expenses.setter
	def expenses(self, value):
		if value < 0:
			raise ValueError("Expenses cannot be negative")
		self.__expenses = value

	def calculate_expenses(self, *args):
		expenses = 0
		for arg in args:
			expenses += 30 * arg.cost

		self.expenses = expenses
		return self.expenses
