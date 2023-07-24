from cat import Cat

import unittest


class CatTests(unittest.TestCase):

	def setUp(self):
		self.cat = Cat("Jane")

	def test_if_cat_is_properly_initialized(self):
		self.assertEqual(self.cat.name, 'Jane')
		self.assertFalse(self.cat.sleepy)
		self.assertFalse(self.cat.fed)
		self.assertEqual(self.cat.size, 0)

	def test_if_cats_size_is_increased_after_eating(self):
		self.cat.eat()
		self.assertEqual(self.cat.size, 1)

	def test_if_cat_is_fed_after_eating(self):
		self.cat.eat()
		self.assertTrue(self.cat.fed)

	def test_if_error_is_raised_if_eat_method_is_called_when_fed_is_true(self):
		self.cat.eat()
		with self.assertRaises(Exception) as ex:
			self.cat.eat()

		self.assertEqual('Already fed.', str(ex.exception))

	def test_if_error_is_raised_if_sleep_method_is_called_when_fed_is_false(self):
		with self.assertRaises(Exception) as ex:
			self.cat.sleep()

		self.assertEqual('Cannot sleep while hungry', str(ex.exception))

	def test_if_cat_is_not_sleepy_after_sleeping(self):
		self.cat.eat()
		self.cat.sleep()
		self.assertFalse(self.cat.sleepy)


if __name__ == '__main__':
	unittest.main()
