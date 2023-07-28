from project.appliances.tv import TV
from .room import Room


class AloneYoung(Room):
	room_cost = 10

	def __init__(self, family_name: str, salary: float):
		self.family_name = family_name
		self.salary = salary
		self.members_count = 1
		self.appliances = [TV()]
		super().__init__(self.family_name, self.salary, self.members_count)

		self.expenses = self.calculate_expenses(*self.appliances)

