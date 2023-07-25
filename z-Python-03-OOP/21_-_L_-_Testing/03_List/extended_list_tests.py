from extended_list import IntegerList

import unittest


class IntegerListTests(unittest.TestCase):
	def setUp(self):
		self.list = IntegerList()

	def test_list_initialization_with_no_arguments(self):
		expected = []
		actual = self.list.get_data()
		self.assertEqual(expected, actual)

	def test_list_initialization_if_some_elements_are_not_valid(self):
		i_list = IntegerList("-42", 0, 1, 2, 3)
		expected = [0, 1, 2, 3]
		actual = i_list.get_data()
		self.assertEqual(expected, actual)

	def test_list_initialization_if_all_elements_are_not_valid(self):
		i_list = IntegerList("42", 3.14)
		expected = []
		actual = i_list.get_data()
		self.assertEqual(expected, actual)

	def test_list_initialization_if_all_elements_are_valid(self):
		i_list = IntegerList(-42, 0, 1, 2, 3)
		expected = [-42, 0, 1, 2, 3]
		actual = i_list.get_data()
		self.assertEqual(expected, actual)

	def test_add_element_is_successful_if_element_is_valid(self):
		self.list.add(42)
		expected = [42]
		actual = self.list.get_data()
		self.assertEqual(expected, actual)

	def test_add_element_raise_error_if_element_is_not_valid(self):
		with self.assertRaises(ValueError) as ex:
			self.list.add("42")

		self.assertEqual(str(ex.exception), "Element is not Integer")

	def test_remove_index_is_successful_if_index_is_valid(self):
		self.list.add(42)
		expected = 42
		actual = self.list.remove_index(0)
		self.assertEqual(expected, actual)

	def test_remove_index_raises_error_if_index_is_not_valid(self):
		with self.assertRaises(IndexError) as ex:
			self.list.remove_index(0)
		expected = "Index is out of range"
		actual = str(ex.exception)
		self.assertEqual(expected, actual)

	def test_get_returns_element_if_index_is_valid(self):
		self.list.add(42)
		expected = 42
		actual = self.list.get(0)
		self.assertEqual(expected, actual)

	def test_get_returns_raise_error_if_index_is_not_valid(self):
		with self.assertRaises(IndexError) as ex:
			self.list.get(0)

		self.assertEqual("Index is out of range", str(ex.exception))

	def test_insert_adds_element_if_index_is_valid(self):
		self.list.add(42)
		self.list.insert(0, 1)
		expected = [1, 42]
		actual = self.list.get_data()
		self.assertEqual(expected, actual)

	def test_insert_raises_error_if_index_is_not_valid(self):
		with self.assertRaises(IndexError) as ex:
			self.list.insert(0, 42)

		self.assertEqual('Index is out of range', str(ex.exception))

	def test_insert_raises_error_if_value_is_not_valid(self):
		self.list.add(42)
		with self.assertRaises(ValueError) as ex:
			self.list.insert(0, "42")

		self.assertEqual('Element is not Integer', str(ex.exception))

	def test_get_biggest_method(self):
		self.list.add(42)
		self.list.add(43)
		expected = 43
		actual = self.list.get_biggest()
		self.assertEqual(expected, actual)

	def test_get_index_method(self):
		self.list.add(42)
		expected = 0
		actual = self.list.get_index(42)
		self.assertEqual(expected, actual)


if __name__ == '__main__':
	unittest.main()
