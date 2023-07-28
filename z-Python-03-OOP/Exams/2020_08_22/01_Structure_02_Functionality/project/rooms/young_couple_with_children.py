from .room import Room
from project.appliances.tv import TV
from project.appliances.fridge import Fridge
from project.appliances.laptop import Laptop


class YoungCoupleWithChildren(Room):
	room_cost = 30

	def __init__(self, family_name: str, salary_one: float, salary_two: float, *children):
		self.family_name = family_name
		self.salary_one = salary_one
		self.salary_two = salary_two
		self.budget = self.salary_one + self.salary_two

		self.children = [*children]
		self.members_count = 2 + len(self.children)
		self.appliances = [TV()] * self.members_count + \
												[Fridge()] * self.members_count + [Laptop()] * self.members_count

		super().__init__(self.family_name, self.budget, self.members_count, self.children)

		appliances_children = self.appliances + self.children
		self.expenses = self.calculate_expenses(*appliances_children)
