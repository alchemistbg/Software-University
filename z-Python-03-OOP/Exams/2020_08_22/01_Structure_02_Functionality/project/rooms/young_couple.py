from .room import Room
from project.appliances.tv import TV
from project.appliances.fridge import Fridge
from project.appliances.laptop import Laptop


class YoungCouple(Room):
	room_cost = 20

	def __init__(self, family_name: str, salary_one: float, salary_two: float):
		self.family_name = family_name
		self.salary_one = salary_one
		self.salary_two = salary_two
		self.budget = self.salary_one + self.salary_two
		self.members_count = 2
		self.appliances = [TV(), TV(), Fridge(), Fridge(), Laptop(), Laptop()]
		super().__init__(self.family_name, self.budget, self.members_count)

		self.expenses = self.calculate_expenses(*self.appliances)
