from unittest import TestCase, main

from project.truck_driver import TruckDriver


class TruckDriverTests(TestCase):

	def setUp(self):
		self.driver = TruckDriver("Pencho", 10.0)

	def test_truck_driver_is_initialized_correctly(self):
		self.assertEqual("Pencho", self.driver.name)
		self.assertEqual(10.0, self.driver.money_per_mile)
		self.assertEqual({}, self.driver.available_cargos)
		self.assertEqual(0, self.driver.earned_money)
		self.assertEqual(0, self.driver.miles)

	def test_if_money_setter_raise_value_error_if_data_is_negative(self):
		with self.assertRaises(ValueError) as ex:
			self.driver.earned_money = -42

		self.assertEqual("Pencho went bankrupt.", str(ex.exception))

	def test_money_setter_if_value_is_valid(self):
		self.driver.earned_money = 42
		self.assertEqual(42, self.driver.earned_money)

	def test_if_add_cargo_offer_raise_exception_if_data_is_invalid(self):
		self.driver.add_cargo_offer("Berkovica", 100)
		with self.assertRaises(Exception) as ex:
			self.driver.add_cargo_offer("Berkovica", 100)

		self.assertEqual("Cargo offer is already added.", str(ex.exception))
		self.assertEqual({"Berkovica": 100}, self.driver.available_cargos)

	def test_add_cargo_offer_if_data_is_valid(self):
		expected = "Cargo for 100 to Berkovica was added as an offer."
		actual = self.driver.add_cargo_offer("Berkovica", 100)
		self.assertEqual(expected, actual)
		self.assertEqual({'Berkovica': 100}, self.driver.available_cargos)
		self.assertEqual(100, self.driver.available_cargos['Berkovica'])
		self.assertTrue('Berkovica' in self.driver.available_cargos)

	def test_if_drive_best_cargo_offer_raise_value_error_if_available_cargos_is_empty(self):
		self.assertEqual("There are no offers available.", self.driver.drive_best_cargo_offer())

	def test_drive_best_cargo_offer_with_valid_data(self):
		expected = "Pencho is driving 1000 to Berkovica."
		self.driver.add_cargo_offer("Berkovica", 1000)
		self.driver.add_cargo_offer("Varna", 100)
		actual = self.driver.drive_best_cargo_offer()

		self.assertEqual(expected, actual)
		self.assertEqual(9875.0, self.driver.earned_money)
		self.assertEqual(1000, self.driver.miles)

	def test_check_for_activities(self):
		self.driver.earned_money = 20000
		self.driver.check_for_activities(10000)
		self.assertEqual(8250, self.driver.earned_money)

	def test_eat(self):
		self.driver.earned_money = 100
		self.assertEqual(100, self.driver.earned_money)
		self.driver.eat(250)
		self.assertEqual(80, self.driver.earned_money)

	def test_sleep(self):
		self.driver.earned_money = 100
		self.assertEqual(100, self.driver.earned_money)
		self.driver.sleep(1000)
		self.assertEqual(55, self.driver.earned_money)

	def test_pump_gas(self):
		self.driver.earned_money = 500
		self.assertEqual(500, self.driver.earned_money)
		self.driver.pump_gas(1500)
		self.assertEqual(0, self.driver.earned_money)

	def test_repair_truck(self):
		self.driver.earned_money = 10000
		self.driver.repair_truck(10000)
		self.assertEqual(2500, self.driver.earned_money)

	def test_repr(self):
		self.driver.add_cargo_offer("Berkovica", 100)
		self.driver.drive_best_cargo_offer()
		expected = "Pencho has 100 miles behind his back."
		actual = str(self.driver)
		self.assertEqual(expected, actual)


if __name__ == "__main__":
	main()
