from abc import ABC, abstractmethod


class Vehicle(ABC):

	@abstractmethod
	def drive(self):
		pass

	@abstractmethod
	def refuel(self):
		self


class Car(Vehicle):
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
