from project.vehicle import Vehicle

import unittest


class VehicleTests(unittest.TestCase):
	def setUp(self):
		self.values = {
			'fuel': 100,
			'capacity': 100,
			'horse_power': 100,
			'fc': 1.25,  # DEFAULT_FUEL_CONSUMPTION,
		}
		self.vehicle = Vehicle(self.values['fuel'], self.values['horse_power'])

	def test_vehicle_is_initialized_correctly(self):
		self.assertEqual(self.values['fuel'], self.vehicle.fuel)
		self.assertEqual(self.values['capacity'], self.vehicle.capacity)
		self.assertEqual(self.values['horse_power'], self.vehicle.horse_power)
		self.assertEqual(self.values['fc'], self.vehicle.fuel_consumption)

	def test_drive_raises_error_if_fuel_not_enough(self):
		with self.assertRaises(Exception) as ex:
			self.vehicle.drive(100)

		self.assertEqual("Not enough fuel", str(ex.exception))

	def test_drive_if_fuel_is_enough(self):
		kilometers = 50
		fuel_needed = self.vehicle.fuel_consumption * kilometers
		expected = self.vehicle.fuel - fuel_needed
		self.vehicle.drive(kilometers)
		actual = self.vehicle.fuel
		self.assertEqual(expected, actual)

	def test_refuel_raises_error_if_fuel_is_not_valid(self):
		with self.assertRaises(Exception) as ex:
			self.vehicle.refuel(1)

		expected = "Too much fuel"
		actual = str(ex.exception)
		self.assertEqual(expected, actual)

	def test_refuel_if_fuel_is_valid(self):
		self.vehicle.fuel = 90
		self.vehicle.refuel(10)
		self.assertEqual(100, self.vehicle.fuel)

	def test_str(self):
		expected = f"The vehicle has {self.values['horse_power']} horse power with " \
				   f"{self.values['fuel']} fuel left and {self.values['fc']} fuel consumption"
		actual = str(self.vehicle)
		self.assertEqual(expected, actual)


if __name__ == '__name__':
	unittest.main()
