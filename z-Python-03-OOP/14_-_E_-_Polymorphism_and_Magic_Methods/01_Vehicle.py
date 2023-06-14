# 100/100

from abc import ABC, abstractmethod


class Vehicle(ABC):

	def __init__(self, fuel_quantity, fuel_consumption):
		self.fuel_quantity = fuel_quantity
		self.fuel_consumption = fuel_consumption

	@property
	@abstractmethod
	def _AC_CONSUMPTION(self):
		...

	def drive(self, distance):
		fuel_needed = distance * (self.fuel_consumption + self._AC_CONSUMPTION)
		if self.fuel_quantity >= fuel_needed:
			self.fuel_quantity -= fuel_needed

	@abstractmethod
	def refuel(self, fuel):
		pass


class Car(Vehicle):
	_AC_CONSUMPTION = 0.9

	def refuel(self, fuel):
		self.fuel_quantity += fuel


class Truck(Vehicle):
	_AC_CONSUMPTION = 1.6

	def refuel(self, fuel):
		self.fuel_quantity += (fuel * 0.95)


# Problem's author's test
# car = Car(20, 5)
# car.drive(3)
# print(car.fuel_quantity)
# car.refuel(10)
# print(car.fuel_quantity)
#
# truck = Truck(100, 15)
# truck.drive(5)
# print(truck.fuel_quantity)
# truck.refuel(50)
# print(truck.fuel_quantity)


# Lecturer's custom tests
def test_vehicle_can_be_instantiated():
	print("Testing vehicle instantiation:")
	print(42 * '-')
	Car(20, 50)
	print('Car instantiate Vehicle successfully')
	Truck(20, 50)
	print('Truck instantiate Vehicle successfully')
	print(42 * '*')


def test_vehicle_could_drive():
	print("Testing vehicle driving:")
	print(42 * '-')
	c = Car(100, 5)
	c.drive(2)
	assert c.fuel_quantity == 88.2, c.fuel_quantity
	print('Car can drive.')
	t = Truck(100, 5)
	t.drive(2)
	assert t.fuel_quantity == 86.8, t.fuel_quantity
	print('Truck can drive.')
	print(42 * '*')


test_vehicle_can_be_instantiated()
test_vehicle_could_drive()
