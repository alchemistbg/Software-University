from abc import ABC, abstractmethod


class Computer(ABC):

	def __init__(self, manufacturer: str, model: str):
		self.manufacturer = manufacturer
		self.model = model
		self.processor = None
		self.ram = None
		self.price = 0

	@property
	def manufacturer(self):
		return self.__manufacturer

	@manufacturer.setter
	def manufacturer(self, value: str):
		if value.strip() == '':
			raise ValueError("Manufacturer name cannot be empty.")

		self.__manufacturer = value

	@property
	def model(self):
		return self.__model

	@model.setter
	def model(self, value: str):
		if value.strip() == '':
			raise ValueError("Model name cannot be empty.")

		self.__model = value

	@abstractmethod
	def configure_computer(self, processor: str, ram: int):
		pass

	def set_props(self, processor, ram):
		self.processor = processor
		self.ram = ram

		self.price += self.processors[processor]
		self.price += (self.valid_ram.index(ram) + 1) * 100

	def __repr__(self):
		return f"{self.manufacturer} {self.model} with {self.processor} and {self.ram}GB RAM"
