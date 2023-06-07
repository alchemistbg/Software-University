from abc import ABC, abstractmethod


class Vehicle(ABC):

	@abstractmethod
	def drive(self):
		pass

	@abstractmethod
	def refuel(self):
		self


class Car(Vehicle):
	def __init__(self, fuel_quantity, fuel_consumption ):
		self.fuel_quantity = fuel_quantity
		self.fuel_consumption = fuel_consumption

	def drive(self):
		pass

	def refuel(self):
		pass


class Truck(Vehicle):
	pass


car = Car(20, 5)
car.drive(3)
print(car.fuel_quantity)
car.refuel(10)
print(car.fuel_quantity)

# truck = Truck(100, 15)
# truck.drive(5)
# print(truck.fuel_quantity)
# truck.refuel(50)
# print(truck.fuel_quantity)
