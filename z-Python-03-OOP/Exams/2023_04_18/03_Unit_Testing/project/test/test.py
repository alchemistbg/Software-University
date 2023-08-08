from project.robot import Robot

from unittest import TestCase, main


class RobotTests(TestCase):

	def setUp(self):
		self.robot1 = Robot("007", "Military", 100, 100)
		self.robot2 = Robot("00", "Military", 100, 100)

	def test_if_robot_is_initialized_correctly(self):
		self.assertEqual("007", self.robot1.robot_id)
		self.assertEqual("Military", self.robot1.category)
		self.assertEqual(100, self.robot1.available_capacity)
		self.assertEqual(100, self.robot1.price)
		self.assertEqual([], self.robot1.hardware_upgrades)
		self.assertEqual([], self.robot1.software_updates)

	def test_category_setter_raise_value_error_if_value_is_invalid(self):
		with self.assertRaises(ValueError) as ex:
			self.robot1.category = "Music"

		self.assertEqual(f"Category should be one of '{self.robot1.ALLOWED_CATEGORIES}'", str(ex.exception))

	def test_category_setter_if_value_is_valid(self):
		self.robot1.category = 'Education'
		self.assertEqual("Education", self.robot1.category)

	def test_price_setter_raise_value_error_if_value_is_invalid(self):
		with self.assertRaises(ValueError) as ex:
			self.robot1.price = -42

		self.assertEqual(f"Price cannot be negative!", str(ex.exception))

	def test_price_setter_if_value_is_valid(self):
		self.robot1.price = 42
		self.assertEqual(42, self.robot1.price)

	def test_upgrade_if_hardware_is_already_in_hardware_list(self):
		expected = f"Robot {self.robot1.robot_id} was not upgraded."
		self.robot1.hardware_upgrades.append('CPU')
		actual = self.robot1.upgrade("CPU", 10)
		self.assertEqual(expected, actual)

	def test_upgrade_if_hardware_is_not_in_hardware_list(self):
		expected = f'Robot 007 was upgraded with CPU.'
		actual = self.robot1.upgrade("CPU", 10)
		self.assertEqual(expected, actual)
		self.assertEqual(115, self.robot1.price)

	def test_update_if_software_version_is_smaller_than_highest_in_software_list(self):
		expected = f"Robot 007 was not updated."
		self.robot1.software_updates.append(42)
		actual = self.robot1.update(41, 10)
		self.assertEqual(expected, actual)

	def test_update_if_available_capacity_is_smaller_needed_capacity(self):
		expected = f"Robot 007 was not updated."
		self.robot1.available_capacity = 10
		actual = self.robot1.update(42, 11)
		self.assertEqual(expected, actual)

	def test_update_if_data_is_ok(self):
		expected = f'Robot 007 was updated to version 42.'
		actual = self.robot1.update(42, 11)
		self.assertEqual(expected, actual)

	def test_greater_than_if_first_robot_is_greater(self):
		self.robot2.price = 50
		expected = f'Robot with ID 007 is more expensive than Robot with ID 00.'
		actual = self.robot1 > self.robot2
		self.assertEqual(expected, actual)

	def test_greater_than_if_second_robot_is_greater(self):
		self.robot2.price = 150
		expected = f'Robot with ID 007 is cheaper than Robot with ID 00.'
		actual = self.robot1 > self.robot2
		self.assertEqual(expected, actual)

	def test_greater_than_if_first_robot_is_greater(self):
		expected = f'Robot with ID 007 costs equal to Robot with ID 00.'
		actual = self.robot1 > self.robot2
		self.assertEqual(expected, actual)


if __name__ == '__main__':
	main()
