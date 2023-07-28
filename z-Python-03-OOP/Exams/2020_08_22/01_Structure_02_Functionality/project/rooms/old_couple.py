from .room import Room
from project.appliances.tv import TV
from project.appliances.fridge import Fridge
from project.appliances.stove import Stove


class OldCouple(Room):
	room_cost = 15

	def __init__(self, family_name: str, pension_one: float, pension_two: float):
		self.family_name = family_name
		self.pension_one = pension_one
		self.pension_two = pension_two
		self.budget = self.pension_one + self.pension_two
		self.members_count = 2
		self.appliances = [TV(), TV(), Fridge(), Fridge(), Stove(), Stove()]
		super().__init__(self.family_name, self.budget, self.members_count)

		self.expenses = self.calculate_expenses(*self.appliances)
