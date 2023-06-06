from abc import ABC, abstractmethod

class Vehicle(ABC):

	@abstractmethod
	def drive(self):
		pass

	@abstractmethod
	def refuel(self):
		self
