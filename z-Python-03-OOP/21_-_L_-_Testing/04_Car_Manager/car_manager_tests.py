from car_manager import Car

import unittest


class CarTests(unittest.TestCase):
	def setUp(self):
		self.car = Car("Ford", "Fiesta", 5, 50)

	def test_car_is_initialized_correctly(self):
		self.assertEqual("Ford", self.car.make)
		self.assertEqual("Fiesta", self.car.model)
		self.assertEqual(5, self.car.fuel_consumption)
		self.assertEqual(50, self.car.fuel_capacity)
		self.assertEqual(0, self.car.fuel_amount)

	def test_raised_exception_if_make_is_none_or_empty(self):
		# Make is None
		with self.assertRaises(Exception) as ex:
			self.car.make = None
		self.assertEqual("Make cannot be null or empty!", str(ex.exception))

		# Make is Empty
		with self.assertRaises(Exception) as ex:
			self.car.make = ""
		self.assertEqual("Make cannot be null or empty!", str(ex.exception))

	def test_raised_exception_if_model_is_none_or_empty(self):
		# Model is None
		with self.assertRaises(Exception) as ex:
			self.car.model = None
		self.assertEqual("Model cannot be null or empty!", str(ex.exception))

		# Model is Empty
		with self.assertRaises(Exception) as ex:
			self.car.model = ""
		self.assertEqual("Model cannot be null or empty!", str(ex.exception))

	def test_raised_exception_if_fuel_consumption_is_none_or_negative(self):
		# Fuel consumption is 0
		with self.assertRaises(Exception) as ex:
			self.car.fuel_consumption = 0
		self.assertEqual("Fuel consumption cannot be zero or negative!", str(ex.exception))

		# Fuel consumption is negative
		with self.assertRaises(Exception) as ex:
			self.car.fuel_consumption = -42
		self.assertEqual("Fuel consumption cannot be zero or negative!", str(ex.exception))

	def test_raised_exception_if_fuel_capacity_is_none_or_negative(self):
		# Fuel capacity is 0
		with self.assertRaises(Exception) as ex:
			self.car.fuel_capacity = 0
		self.assertEqual("Fuel capacity cannot be zero or negative!", str(ex.exception))

		# Fuel consumption is negative
		with self.assertRaises(Exception) as ex:
			self.car.fuel_capacity = -42
		self.assertEqual("Fuel capacity cannot be zero or negative!", str(ex.exception))

	def test_raised_exception_if_fuel_amount_is__negative(self):
		with self.assertRaises(Exception) as ex:
			self.car.fuel_amount = -42
		self.assertEqual("Fuel amount cannot be negative!", str(ex.exception))

	def test_refuel_raises_exception_if_fuel_none_or_negative(self):
		# Fuel is 0
		with self.assertRaises(Exception) as ex:
			self.car.refuel(0)
		self.assertEqual("Fuel amount cannot be zero or negative!", str(ex.exception))

		# Fuel is negative
		with self.assertRaises(Exception) as ex:
			self.car.refuel(-42)
		self.assertEqual("Fuel amount cannot be zero or negative!", str(ex.exception))

	def test_refuel_if_value_is_valid(self):
		self.car.refuel(42)
		expected = 42
		actual = self.car.fuel_amount
		self.assertEqual(expected, actual)

	def test_refuel_if_value_is_valid_and_bigger_than_capacity(self):
		self.car.refuel(420)
		expected = 50
		actual = self.car.fuel_amount
		self.assertEqual(expected, actual)

	def test_drive_raises_error_if_needed_fuel_is_less_than_available(self):
		self.car.fuel_amount = 42
		with self.assertRaises(Exception) as ex:
			self.car.drive(1000)
		self.assertEqual("You don't have enough fuel to drive!", str(ex.exception))

	def test_drive_if_needed_fuel_is_more_than_available(self):
		self.car.fuel_amount = 420
		self.car.drive(10)
		expected = 419.5
		actual = self.car.fuel_amount
		self.assertEqual(expected, actual)


if __name__ == '__main__':
	unittest.main()
