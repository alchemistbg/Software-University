from abc import ABC, abstractmethod


class BaseService(ABC):

	def __init__(self, name: str, capacity: int):
		self.name = name
		self.capacity = capacity
		self.robots = []

	@abstractmethod
	def details(self):
		pass

	@property
	def name(self):
		return self.__name

	@name.setter
	def name(self, value: str):
		if value.strip() == "":
			raise ValueError("Service name cannot be empty!")
		self.__name = value

	@property
	def capacity(self):
		return self.__capacity

	@capacity.setter
	def capacity(self, value):
		if value <= 0:
			raise ValueError("Service capacity cannot be less than or equal to 0!")
		self.__capacity = value

	def _get_robots_names(self):
		if self.robots:
			return " ".join([robot.name for robot in self.robots])
		return "none"

