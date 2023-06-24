from abc import ABC, abstractmethod


class FormulaTeam(ABC):

	def __init__(self, budget):
		self.budget = budget

	@property
	@abstractmethod
	def budget(self):
		...

	@budget.setter
	@abstractmethod
	def budget(self, value):
		if value < 1000000:
			raise ValueError('F1 is an expensive sport, find more sponsors!')
		self.budget = value

	@abstractmethod
	def calculate_revenue_after_race(self, race_pos: int):
		...
