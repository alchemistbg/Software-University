from typing import ClassVar


class Vehicle:
	DEFAULT_FUEL_CONSUMPTION: ClassVar[float] = 1.25

	def __init__(self, fuel: float, horse_power: int):
		self.fuel = fuel
		self.horse_power = horse_power
		self.fuel_consumption: float = self.__class__.DEFAULT_FUEL_CONSUMPTION

	def drive(self, kilometres):
		needed_fuel = self.fuel_consumption * kilometres
		if self.fuel >= needed_fuel:
			self.fuel -= needed_fuel
			return kilometres
