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

	@property
	@abstractmethod
	def processors(self):
		pass

	@property
	@abstractmethod
	def valid_ram(self):
		pass

	# @abstractmethod
	def configure_computer(self, processor: str, ram: int):
		price = 0

		if processor not in self.processors:
			raise ValueError(f"{processor} is not compatible with {self.type} {self.manufacturer} {self.model}!")

		if ram not in self.valid_ram or ram > self.__class__.valid_ram[-1]:
			raise ValueError(f"{ram}GB RAM is not compatible with {self.type} {self.manufacturer} {self.model}!")

		price += self.processors[processor]
		price += (self.valid_ram.index(ram) + 1) * 100

		self.processor = processor
		self.ram = ram
		self.price = price

		return f"Created {self.manufacturer} {self.model} with {processor} and {ram}GB RAM for {self.price}$."

	def __repr__(self):
		return f"{self.manufacturer} {self.model} with {self.processor} and {self.ram}GB RAM"
